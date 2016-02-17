using System.Threading.Tasks;
using System.Net.Http;

namespace SecMobile.Core.Contracts
{
	public class BaseRequest
	{
		private HttpClient _client;

		private HttpClient Client
		{
			get { return _client ?? (_client = new HttpClient()); }
		}

		public async Task<HttpResponseMessage> GetResponseAsync(HttpMethod httpMethod, string url)
		{
			var myRequest = new HttpRequestMessage(httpMethod, url);
			var response = await Client.SendAsync(myRequest);
			return response;
		}
	}
}
