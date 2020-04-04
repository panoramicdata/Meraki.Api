using Meraki.Api.Exceptions;
using System;using System.Threading.Tasks;

namespace Meraki.Api
{
	/// <summary>
	/// MerakiClient options
	/// </summary>
	public class MerakiClientOptions
	{
		/// <summary>
		/// The API Node (e.g. "n72").
		/// This is optional, but highly recommended as directly addressing the correct instance will reduce propagation delays.
		/// If this is NOT provided, you may experience 404 errors when accessing recently-added objects.
		/// </summary>
		public string? ApiNode { get; set; } = null;

		/// <summary>
		/// The API key
		/// </summary>
		public string ApiKey { get; set; } = string.Empty;

		/// <summary>
		/// When a 429 HttpStatus code is sent, the back-off duration doubles on each attempt.
		/// This option sets the maximum backoff duration.
		/// </summary>
		public TimeSpan MaxBackOffDelay { get; set; } = TimeSpan.FromSeconds(5);

		public void Validate()
		{
			// ApiNode
			if (ApiNode != null && string.IsNullOrWhiteSpace(ApiNode))
			{
				throw new ConfigurationException($"Missing {nameof(ApiNode)}.  If not required, set {nameof(ApiNode)} to null.");
			}

			// ApiKey
			if (string.IsNullOrWhiteSpace(ApiKey))
			{
				throw new ConfigurationException($"Missing {nameof(ApiKey)}.");
			}

			// MaxBackoffDelay
			if (MaxBackOffDelay < TimeSpan.Zero)
			{
				throw new ConfigurationException($"{nameof(MaxBackOffDelay)} should not be less than zero.");
			}
		}
	}
}