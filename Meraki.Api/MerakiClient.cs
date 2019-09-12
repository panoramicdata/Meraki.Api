using Meraki.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;
using System;
using System.Net.Http;

namespace Meraki.Api
{
	public class MerakiClient : IDisposable
	{
		private readonly ILogger _logger;
		private readonly HttpClient _httpClient;

		/// <summary>
		/// A Meraki portal client
		/// </summary>
		/// <param name="options"></param>
		/// <param name="logger"></param>
		public MerakiClient(MerakiClientOptions options, ILogger logger = default!)
		{
			_logger = logger ?? NullLogger.Instance;
			_httpClient = new HttpClient(new AuthenticatedHttpClientHandler(options ?? throw new ArgumentNullException(nameof(options)))) { BaseAddress = new Uri("https://api.meraki.com/api/v0/") };
			Organizations = RestService.For<IOrganizations>(_httpClient);
		}

		public IOrganizations Organizations { get; }

		public void Dispose()
		{
			_logger.LogDebug("Disposing...");
			_httpClient.Dispose();
			_logger.LogDebug("Disposed");
		}
	}
}
