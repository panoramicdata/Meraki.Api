using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Third party vpn peers
	/// </summary>
	[DataContract]
	public class ThirdPartyVpnPeers
	{
		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Public IP
		/// </summary>
		[DataMember(Name = "publicIp")]
		public string PublicIp { get; set; } = string.Empty;

		/// <summary>
		/// Reachability
		/// </summary>
		[DataMember(Name = "reachability")]
		public string Reachability { get; set; } = string.Empty;
	}
}
