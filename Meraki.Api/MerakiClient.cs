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
		private readonly AuthenticatedBackingOffHttpClientHandler _httpClientHandler;

		/// <summary>
		/// A Meraki portal client	
		/// </summary>
		/// <param name="options"></param>
		/// <param name="logger"></param>
		public MerakiClient(MerakiClientOptions options, ILogger logger = default!)
		{
			_logger = logger ?? NullLogger.Instance;
			_httpClientHandler = new AuthenticatedBackingOffHttpClientHandler(options ?? throw new ArgumentNullException(nameof(options)));
			_httpClient = new HttpClient(_httpClientHandler) { BaseAddress = new Uri("https://api.meraki.com/api/v0/") };

			Admins = RestService.For<IAdmins>(_httpClient);
			ApiUsages = RestService.For<IApiUsages>(_httpClient);
			Organizations = RestService.For<IOrganizations>(_httpClient);
			Networks = RestService.For<INetworks>(_httpClient);
		}

		public IAdmins Admins { get; }
		public IApiUsages ApiUsages { get; }
		public INetworks Networks { get; }
		public IOrganizations Organizations { get; }

		#region IDisposable Support
		private bool _disposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposedValue)
			{
				if (disposing)
				{
					_logger.LogDebug(Resources.Disposing);
					_httpClient.Dispose();
					_httpClientHandler.Dispose();
					_logger.LogDebug(Resources.Disposed);
				}

				_disposedValue = true;
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);

			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
