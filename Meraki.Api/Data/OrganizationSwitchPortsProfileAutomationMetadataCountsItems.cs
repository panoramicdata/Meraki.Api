namespace Meraki.Api.Data;

/// <summary>
/// Meta data of the items
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationMetadataCountsItems
{
	/// <summary>
	/// Total number of automation profiles
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}