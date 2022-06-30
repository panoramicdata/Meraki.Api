namespace Meraki.Api.Data;

[DataContract]
public class DeviceStatusOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public DeviceStatusOverviewCounts Counts { get; set; } = new();
}
