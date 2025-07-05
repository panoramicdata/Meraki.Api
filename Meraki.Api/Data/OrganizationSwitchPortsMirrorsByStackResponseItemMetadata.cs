namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemMetadata
{
	/// <summary>
	/// Counts of the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsMirrorsByStackResponseItemMetadataCounts Counts { get; set; } = new();
}
