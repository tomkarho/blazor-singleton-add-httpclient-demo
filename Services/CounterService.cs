using Microsoft.Extensions.Logging;

namespace AddHttpClientSingletonExample.Services
{
    public class CounterService : ICounterService
    {
        private ILogger<CounterService> _log;
        private int _count = 0;

        public CounterService(ILogger<CounterService> log)
        {
            _log = log;
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