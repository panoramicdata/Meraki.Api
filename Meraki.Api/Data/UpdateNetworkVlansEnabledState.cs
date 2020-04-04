using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkVlansEnabledState
	/// </summary>
	[DataContract]
	public partial class VlansEnabledState
	{
		/// <summary>
		/// Boolean indicating whether to enable (true) or disable (false) VLANs for the network
		/// </summary>
		/// <value>Boolean indicating whether to enable (true) or disable (false) VLANs for the network</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }
	}
}
