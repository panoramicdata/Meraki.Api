using System;

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
	}
}