using ASP.NETGames.Infrastructure.JsonConverters;
using ASP.NETGames.Models;
using ASP.NETGames.Options;
using Microsoft.AspNetCore.WebUtilities;
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

        public GamesService(IHttpClientFactory httpClientFactory, IOptions<GamesApiOptions> options)
        {
            this.httpClient = httpClientFactory.CreateClient();
            this.url = options.Value.Url;
        }

        public async Task<GameDetails> SearchByIdAsync(int id)
        {
            var request = $"{url}games/{id}";
            var response = await httpClient.GetAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions();
            options.Converters.Add(new ConverterDictionaryTKeyEnumTValue());
            return JsonSerializer.Deserialize<GameDetails>(json, options);
        }

        public async Task<SearchByNameResponce> SearchByTitleAsync(string search, int page, int pageSize)
        {
            var urlSearch = System.Web.HttpUtility.UrlEncode(search?.Trim());

            string searchQuery = url + "/games";
            if (!string.IsNullOrWhiteSpace(urlSearch))
                searchQuery = QueryHelpers.AddQueryString(searchQuery, "search", urlSearch);
            var request = QueryHelpers.AddQueryString(searchQuery, 
                        new Dictionary<string, string> { { "page", page.ToString() }, { "page_size", pageSize.ToString() } });

            var response = await httpClient.GetAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions();
            options.Converters.Add(new ConverterDictionaryTKeyEnumTValue());
            var result = JsonSerializer.Deserialize<SearchByNameResponce>(json, options);

            result.Page = page;
            result.PageCount = (int)Math.Ceiling((double)result.count / 12);
            return result;
        }
    }
}
