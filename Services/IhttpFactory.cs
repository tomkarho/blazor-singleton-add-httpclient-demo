using System.Net.Http;

namespace AddHttpClientSingletonExample.Services
{
    public interface IhttpFactory
    {
       HttpClient GetClient();
    }
}