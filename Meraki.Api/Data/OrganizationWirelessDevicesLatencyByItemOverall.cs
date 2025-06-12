namespace Meraki.Api.Data;

/// <summary>
/// Overall latency metrics.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesLatencyByItemOverall
{
	/// <summary>
	/// Number of MSDUs (WiFi frames).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "frames")]
	public int Frames { get; set; }

	/// <summary>
	/// Average Latency in milliseconds.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }
}