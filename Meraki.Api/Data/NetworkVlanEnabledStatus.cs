using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// A network VLAN enabled status
/// </summary>
[DataContract]
public class NetworkVlanEnabledStatus
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Network Id
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;
}
