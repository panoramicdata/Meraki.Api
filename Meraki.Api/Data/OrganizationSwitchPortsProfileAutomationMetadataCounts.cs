namespace Meraki.Api.Data;

/// <summary>
/// Counts of the result
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationMetadataCounts
{
	/// <summary>
	/// Meta data of the items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationSwitchPortsProfileAutomationMetadataCountsItems Items { get; set; } = new();
}