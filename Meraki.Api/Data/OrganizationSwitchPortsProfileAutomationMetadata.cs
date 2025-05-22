namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationMetadata
{
	/// <summary>
	/// Counts of the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsProfileAutomationMetadataCounts Counts { get; set; } = new();
}
