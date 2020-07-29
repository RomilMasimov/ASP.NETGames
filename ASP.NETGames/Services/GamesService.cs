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
        private readonly HttpClient _httpClient;
        private readonly string _url;
        private readonly IMemoryCache _cache;

        public GamesService(IHttpClientFactory httpClientFactory, IOptions<GamesApiOptions> options,
            IMemoryCache memoryCache)
        {
            this._httpClient = httpClientFactory.CreateClient();
            this._url = options.Value.Url;
            _cache = memoryCache;
        }

        public async Task<GameDetails> SearchByIdAsync(int id)
        {
            if (_cache.TryGetValue(id.ToString(), out GameDetails result))
                return result;

            var requestUrl = $"{_url}/games/{id}";
            var response = await _httpClient.GetAsync(requestUrl);
            var json = await response.Content.ReadAsStringAsync();

            var serializerOptions = new JsonSerializerOptions();
            serializerOptions.Converters.Add(new ConverterDictionaryTKeyEnumTValue());
            result = JsonSerializer.Deserialize<GameDetails>(json, serializerOptions);

            var screenshotsResponse = await _httpClient.GetAsync(requestUrl + "/screenshots");
            var screenshotsJsonResponse = await screenshotsResponse.Content.ReadAsStringAsync();
            var screenshotsObjectResponse =
                JsonSerializer.Deserialize<ScreenshotsByIdResponce>(screenshotsJsonResponse);
            result.screenshots =
                new List<Screenshots>(screenshotsObjectResponse.results ?? Enumerable.Empty<Screenshots>());

            _cache.Set($"{id}", result);
            return result;
        }

        public async Task<SearchByNameResponce> SearchByTitleAsync(string search, string ordering, int page = 1,
            int pageSize = 12)
        {
            search = search?.Trim();
            if (_cache.TryGetValue($"s{search}o{ordering}p{page}ps{pageSize}", out SearchByNameResponce result))
                return result;

            var searchUrlValue = System.Web.HttpUtility.UrlEncode(search);

            string requestUrl = _url + "/games";
            if (string.IsNullOrWhiteSpace(searchUrlValue) == false)
                requestUrl = QueryHelpers.AddQueryString(requestUrl, "search", searchUrlValue);
            var request = QueryHelpers.AddQueryString(requestUrl,
                new Dictionary<string, string>
                    {{"ordering", ordering ?? ""}, {"page", page.ToString()}, {"page_size", pageSize.ToString()}});

            var response = await _httpClient.GetAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            var serializerOptions = new JsonSerializerOptions();
            serializerOptions.Converters.Add(new ConverterDictionaryTKeyEnumTValue());
            result = JsonSerializer.Deserialize<SearchByNameResponce>(json, serializerOptions);

            result.Page = page;
            result.PageCount = (int) Math.Ceiling((double) result.count / 12);

            _cache.Set($"s{search}o{ordering}p{page}ps{pageSize}", result);
            return result;
        }
    }
}