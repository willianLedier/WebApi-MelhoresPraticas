using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAppMVC.Services
{
    public interface IHttpClientCustom
    {
        Uri? BaseAddress { get; set; }
        Task PostAsync(string requestUri, object value);
        Task<T> PostAsync<T>(string requestUri, object value) where T : new();
        Task<T> GetAsync<T>(string requestUri) where T : new();
        Task<StringContent> GetContent(object value);
    }
}
