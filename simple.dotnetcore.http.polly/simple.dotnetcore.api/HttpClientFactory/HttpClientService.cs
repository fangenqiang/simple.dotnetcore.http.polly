using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using simple.dotnetcore.http.Extensions;
using simple.dotnetcore.http.Priority;

namespace simple.dotnetcore.api.HttpClientFactory
{
    public class HttpClientService : IHttpClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public HttpClientService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }   

        public async Task<TResponse> PostAsJsonAsync<TResponse>(HttpClientPriority priority, string requestUri, object value, AuthenticationHeaderValue authorization = null)
        {
            var name = Enum.GetName(typeof(HttpClientPriority), priority);
            return await PostAsJsonAsync<TResponse>(name, requestUri, value, authorization);
        }

        public async Task<TResponse> PostAsJsonAsync<TResponse>(string name, string requestUri, object value, AuthenticationHeaderValue authorization = null)
        {
            var client = _httpClientFactory.CreateClient(name);
            return await client.PostAsJsonAsync<TResponse>(requestUri, value, authorization);
        }
    }
}
