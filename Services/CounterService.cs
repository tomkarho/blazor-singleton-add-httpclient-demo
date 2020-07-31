using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace AddHttpClientSingletonExample.Services
{
    public class CounterService : ICounterService
    {
        private HttpClient _http;
        private ILogger<CounterService> _log;
        private int _count = 0;

        public CounterService(ILogger<CounterService> log, HttpClient http)
        {
            _log = log;
            _http = http;
            _log.LogInformation("CounterService ctor");
        }

        public void AddCount()
        {
            _count++;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}