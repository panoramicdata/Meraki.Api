namespace Meraki.Api.Data;

/// <summary>
/// An object containing non-wifi utilization.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationByBandItemNonWifi
{
	/// <summary>
	/// Percentage of non-wifi channel utiliation for the given band.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}