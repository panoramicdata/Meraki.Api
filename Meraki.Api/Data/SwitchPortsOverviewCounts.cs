namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts
/// </summary>
[DataContract]
public class SwitchPortsOverviewCounts
{
	/// <summary>
	/// The total number of ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// The count data, indexed by active or inactive status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public SwitchPortsOverviewCountsByStatus ByStatus { get; set; } = new();
}
