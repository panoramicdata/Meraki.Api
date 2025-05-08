namespace Meraki.Api.Data;

/// <summary>
/// Wireless Location Scanning By Network
/// </summary>
[DataContract]
public class WirelessLocationScanningByNetwork
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public WirelessLocationScanningByNetworkMetadata Meta { get; set; } = new();

	/// <summary>
	/// Paginated list of scanning settings by network ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<WirelessLocationScanningByNetworkItem> Items { get; set; } = [];
}
