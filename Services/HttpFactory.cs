using System;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace AddHttpClientSingletonExample.Services
{
    public class HttpFactory : IhttpFactory
    {
        private HttpOptions _options;
        private HttpClient _client;

        public HttpFactory(IOptions<HttpOptions> options)
        {
            _options = options.Value;
            _client = new HttpClient
            {
                BaseAddress = new Uri(_options.BaseUrl)
            };
        }

        public HttpClient GetClient()
        {
            return _client;
        }
    }
}