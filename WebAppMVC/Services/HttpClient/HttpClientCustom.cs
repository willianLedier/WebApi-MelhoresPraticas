using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAppMVC.Services
{
    public class HttpClientCustom : IHttpClientCustom
    {

        private readonly HttpClient _httpClient;

        public Uri? BaseAddress { get; set; }

        public HttpClientCustom(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task PostAsync(string requestUri, object value)
        {
            var content = await GetContent(value);
            var response = await _httpClient.PostAsync(requestUri, content);

            if (response.IsSuccessStatusCode)
            {
            }

        }

        public async Task<T> PostAsync<T>(string requestUri, object value) where T : new()
        {
            var content = await GetContent(value);
            var response = await _httpClient.PostAsync(requestUri, content);

            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync());
            }

            return new T();
        }

        public async Task<T> GetAsync<T>(string requestUri) where T : new()
        {

            var response = await _httpClient.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync());
            }

            return new T();
        }

        public async Task<StringContent> GetContent(object value)
        {
            var payloadJson = JsonSerializer.Serialize(value);
            var content = new StringContent(payloadJson, Encoding.UTF8, "application/json");
            return content;
        }

    }
}
