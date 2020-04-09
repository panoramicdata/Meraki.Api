using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api
{
	internal class AuthenticatedBackingOffHttpClientHandler : HttpClientHandler
	{
		private readonly MerakiClientOptions _options;
		private readonly ILogger _logger;
		private readonly LogLevel _levelToLogAt = LogLevel.Debug;

		public AuthenticatedBackingOffHttpClientHandler(MerakiClientOptions options, ILogger logger)
		{
			_options = options;
			_logger = logger;
		}

		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			HttpResponseMessage httpResponseMessage;

			while (true)
			{
				cancellationToken.ThrowIfCancellationRequested();

				// Ensure the API key is set
				if (_options.ApiKey?.Length == 0)
				{
					throw new InvalidOperationException(Resources.ApiKeyIsNotSet);
				}
				// The API Key is set

				// Add the request headers
				request.Headers.Add("X-Cisco-Meraki-API-Key", _options.ApiKey);

				// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
				if (_logger.IsEnabled(_levelToLogAt))
				{
					_logger.Log(_levelToLogAt, $"Request\r\n{request}");
					if (request.Content != null)
					{
						_logger.Log(_levelToLogAt, "RequestContent\r\n" + await request.Content.ReadAsStringAsync().ConfigureAwait(false));
					}
				}

				// Complete the action
				httpResponseMessage = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

				// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
				if (_logger.IsEnabled(_levelToLogAt))
				{
					_logger.Log(_levelToLogAt, $"Response\r\n{httpResponseMessage}");
					if (httpResponseMessage.Content != null)
					{
						_logger.Log(_levelToLogAt, "ResponseContent\r\n" + await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
					}
				}

				// As long as we were not given a back-off request then we'll return the response and any further StatusCode handling is up to the caller
				if ((int)httpResponseMessage.StatusCode != 429)
				{
					return httpResponseMessage;
				}

				// We have a 429.  Back off by the requested amount.

				// Get the Retry-After header if present;
				var headers = httpResponseMessage.Headers;
				var retryAfterSecondsString = headers.TryGetValues("Retry-After", out var retryAfterHeaders)
					? retryAfterHeaders.FirstOrDefault() ?? "1"
					: "1";

				if (!int.TryParse(retryAfterSecondsString, out var retryAfterSeconds))
				{
					retryAfterSeconds = 1;
				}
				var delay = TimeSpan.FromSeconds(1.1 * retryAfterSeconds);

				// There is no maximum total wait time.
				await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
			}
		}
	}
}
