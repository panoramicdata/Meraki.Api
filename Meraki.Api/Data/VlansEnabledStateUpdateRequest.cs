using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkVlansEnabledState
	/// </summary>
	[DataContract]
	public class VlansEnabledState
	{
		/// <summary>
		/// Boolean indicating whether to enable (true) or disable (false) VLANs for the network
		/// </summary>
		/// <value>Boolean indicating whether to enable (true) or disable (false) VLANs for the network</value>
		[DataMember(Name = "enabled")]
		public bool? Enabled { get; set; }
	}
}
