namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatus
{
	/// <summary>
	/// The count data for active ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "active")]
	public SwitchPortsOverviewCountsByStatusActive Active { get; set; } = new();

	/// <summary>
	/// The count data for inactive ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "inactive")]
	public SwitchPortsOverviewCountsByStatusInactive Inactive { get; set; } = new();
}
