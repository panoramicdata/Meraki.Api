using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Splash authorization for SSID 0
	/// </summary>
	[DataContract]
	public class GeneratedObject10
	{
		/// <summary>
		/// New authorization status for the SSID (true, false).
		/// </summary>
		/// <value>New authorization status for the SSID (true, false).</value>
		[DataMember(Name = "isAuthorized", EmitDefaultValue = false)]
		public bool? IsAuthorized { get; set; }

		/// <summary>
		/// Authorized at
		/// </summary>
		[DataMember(Name = "authorizedAt")]
		public string? AuthorizedAt { get; set; }

		/// <summary>
		/// Expires at
		/// </summary>
		[DataMember(Name = "expiresAt")]
		public string? ExpiresAt { get; set; }
	}
}
