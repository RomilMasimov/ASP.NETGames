using ASP.NETGames.Infrastructure.JsonConverters;
using ASP.NETGames.Models;
using ASP.NETGames.Options;
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

        public async Task<SearchByNameResponce> SearchByTitleAsync(string title)
        {
            var request = $"{url}games?search={title}";
            var response = await httpClient.GetAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions();
            options.Converters.Add(new ConverterDictionaryTKeyEnumTValue());
            return JsonSerializer.Deserialize<SearchByNameResponce>(json, options);
        }
    }
}
