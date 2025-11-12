namespace Meraki.Api.Data;

/// <summary>
/// Device Status Overview Counts
/// </summary>
[DataContract]
public class DeviceStatusOverviewCounts
{
	/// <summary>
	/// Bystatus
	/// </summary>
	[DataMember(Name = "byStatus")]
	public DeviceStatusOverviewCountsByStatus ByStatus { get; set; } = new();
}
