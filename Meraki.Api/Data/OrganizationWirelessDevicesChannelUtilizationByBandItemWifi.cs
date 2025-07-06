namespace Meraki.Api.Data;

/// <summary>
/// An object containing wifi utilization.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationByBandItemWifi
{
	/// <summary>
	/// Percentage of wifi channel utiliation for the given band.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}