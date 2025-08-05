namespace Meraki.Api.Data;

/// <summary>
/// An object containing total channel utilization.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesChannelUtilizationByBandItemTotal
{
	/// <summary>
	/// Percentage of total channel utiliation for the given band.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}