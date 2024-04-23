namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Inactive
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusInactive
{
	/// <summary>
	/// The total number of inactive ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// The inactive count data, indexed by media type (RJ45 or SFP)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byMedia")]
	public SwitchPortsOverviewCountsByStatusInactiveByMedia ByMedia { get; set; } = new();
}
