namespace Meraki.Api.Data;

/// <summary>
/// Scanning setting Item
/// </summary>
[DataContract]
public class WirelessLocationScanningByNetworkItem
{
	/// <summary>
	/// Network Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Whether to enable collection of location and scanning analytics
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Whether to enable collection of location and scanning analytics
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "api")]
	public WirelessLocationScanningByNetworkApi Api { get; set; } = new();
}
