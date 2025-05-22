namespace Meraki.Api.Data;

/// <summary>
/// Wireless Location Scanning Receivers
/// </summary>
[DataContract]
public class WirelessLocationScanningReceivers
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public WirelessLocationScanningMetadata Meta { get; set; } = new();

	/// <summary>
	/// Paginated list of scanning api receivers by network ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<WirelessReceiver> Items { get; set; } = [];
}
