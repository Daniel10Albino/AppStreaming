
namespace AppStreaming.Properties.Services.RequestProvider
{
   public class RequestProvider : IRequestProvider
    {
        public Lazy<HttpClient> HttpClient { get; } = new(static () =>
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.HttpRequestHeaders.MediaTypeWithQualityHeaderValue ("application/json"));
            return httpClient;
        });

        public Task PostAsync<Tsend>(string uri, Tsend data, string token = "")
        {
            throw new NotImplementedException();
        }
    }
}
