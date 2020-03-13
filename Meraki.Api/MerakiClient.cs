using Meraki.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using Refit;
using System;
using System.Net.Http;

namespace Meraki.Api
{
	/// <summary>
	/// A Meraki Dashboard API client
	/// </summary>
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
		public MerakiClient(MerakiClientOptions options, ILogger? logger = default)
		{
			_logger = logger ?? NullLogger.Instance;
			_httpClientHandler = new AuthenticatedBackingOffHttpClientHandler(options ?? throw new ArgumentNullException(nameof(options)), _logger);
			_httpClient = new HttpClient(_httpClientHandler) { BaseAddress = new Uri($"https://{options.ApiNode ?? "api"}.meraki.com/api/v0/") };

			var refitSettings = new RefitSettings
			{
				ContentSerializer = new JsonContentSerializer(
				new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				})
			};

			Admins = RestService.For<IAdmins>(_httpClient, refitSettings);
			ApiUsages = RestService.For<IApiUsages>(_httpClient, refitSettings);
			Organizations = RestService.For<IOrganizations>(_httpClient, refitSettings);
			Networks = RestService.For<INetworks>(_httpClient, refitSettings);
			Devices = RestService.For<IDevices>(_httpClient, refitSettings);
		}

		/// <summary>
		/// Admins
		/// </summary>
		public IAdmins Admins { get; }

		/// <summary>
		/// API Usages
		/// </summary>
		public IApiUsages ApiUsages { get; }

		/// <summary>
		/// Devices
		/// </summary>
		public IDevices Devices { get; }

		/// <summary>
		/// Networks
		/// </summary>
		public INetworks Networks { get; }

		/// <summary>
		/// Organizations
		/// </summary>
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
