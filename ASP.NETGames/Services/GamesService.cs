using ASP.NETGames.Infrastructure.JsonConverters;
using ASP.NETGames.Models;
using ASP.NETGames.Options;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASP.NETGames.Services
{
    public class GamesService : IGamesService
    {
        private readonly HttpClient httpClient;
        private readonly string url;
        private readonly IMemoryCache cache;

        public GamesService(IHttpClientFactory httpClientFactory, IOptions<GamesApiOptions> options, IMemoryCache memoryCache)
        {
            this.httpClient = httpClientFactory.CreateClient();
            this.url = options.Value.Url;
            cache = memoryCache;
        }
        
        public async Task<GameDetails> SearchByIdAsync(int id)
        {
            if (cache.TryGetValue($"{id}", out GameDetails result))
                return result;

            var request = $"{url}/games/{id}";
            var responce = await httpClient.GetAsync(request);
            var json = await responce.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions();
            options.Converters.Add(new ConverterDictionaryTKeyEnumTValue());
            result = JsonSerializer.Deserialize<GameDetails>(json, options);

            var screenshorsRespoce = await httpClient.GetAsync(request + "/screenshots");
            var screenshorsJsonRespoce = await screenshorsRespoce.Content.ReadAsStringAsync();
            var screenshorsObjectRespoce = JsonSerializer.Deserialize<ScreenshotsByIdResponce>(screenshorsJsonRespoce);
            result.screenshots = new List<Screenshots>(screenshorsObjectRespoce.results ?? Enumerable.Empty<Screenshots>());

            cache.Set($"{id}", result);
            return result;
        }

        public async Task<SearchByNameResponce> SearchByTitleAsync(string search, string ordering, int page = 1, int pageSize = 12)
        {
            search = search?.Trim();
            if (cache.TryGetValue($"s{search}o{ordering}p{page}ps{pageSize}", out SearchByNameResponce result))
                return result;
            
            var urlSearch = System.Web.HttpUtility.UrlEncode(search);

            string searchQuery = url + "/games";
            if (!string.IsNullOrWhiteSpace(urlSearch))
                searchQuery = QueryHelpers.AddQueryString(searchQuery, "search", urlSearch);
            var request = QueryHelpers.AddQueryString(searchQuery,
                        new Dictionary<string, string> { { "ordering", ordering ?? "" }, { "page", page.ToString() }, { "page_size", pageSize.ToString() } });

            var response = await httpClient.GetAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions();
            options.Converters.Add(new ConverterDictionaryTKeyEnumTValue());
            result = JsonSerializer.Deserialize<SearchByNameResponce>(json, options);

            result.Page = page;
            result.PageCount = (int)Math.Ceiling((double)result.count / 12);

            cache.Set($"s{search}o{ordering}p{page}ps{pageSize}", result);
            return result;
        }
    }
}
