using System;

namespace Meraki.Api
{
	/// <summary>
	/// MerakiClient options
	/// </summary>
	public class MerakiClientOptions
	{
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