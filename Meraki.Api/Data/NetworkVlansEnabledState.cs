namespace Meraki.Api.Data;

/// <summary>
/// Network VLANs enabled state
/// </summary>
[DataContract]
public class NetworkVlansEnabledState
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
