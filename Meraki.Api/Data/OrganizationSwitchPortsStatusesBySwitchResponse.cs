namespace Meraki.Api.Data;

/// <summary>
/// Paginated list of switch port statuses grouped by switch in an organization
/// </summary>
[DataContract]
public class OrganizationSwitchPortsStatusesBySwitchResponse
	: ItemsResponseWithMeta<SwitchPortsStatusesBySwitch>
{
	/// <summary>
	/// Switches with their port statuses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<SwitchPortsStatusesBySwitch> Items { get; set; } = [];
}
