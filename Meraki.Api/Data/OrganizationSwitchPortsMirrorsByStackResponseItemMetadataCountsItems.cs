namespace Meraki.Api.Data;

/// <summary>
/// Meta data of the items
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByStackResponseItemMetadataCountsItems
{
	/// <summary>
	/// Total number of port mirror configurations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}