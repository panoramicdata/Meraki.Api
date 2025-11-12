namespace Meraki.Api.Data;

/// <summary>
/// Device Status Overview
/// </summary>
[DataContract]
public class DeviceStatusOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public DeviceStatusOverviewCounts Counts { get; set; } = new();
}
