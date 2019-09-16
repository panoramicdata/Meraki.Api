using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api
{
	internal class AuthenticatedHttpClientHandler : HttpClientHandler
	{
		private readonly MerakiClientOptions _options;

		public AuthenticatedHttpClientHandler(MerakiClientOptions options)
		{
			_options = options;
		}

		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			// Ensure the API key is set
			if (_options.ApiKey?.Length == 0)
			{
				throw new InvalidOperationException(Resources.ApiKeyIsNotSet);
			}
			// The API Key is set

			// Add the request headers
			request.Headers.Add("X-Cisco-Meraki-API-Key", _options.ApiKey);

			// Complete the action
			return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
		}
	}
}
