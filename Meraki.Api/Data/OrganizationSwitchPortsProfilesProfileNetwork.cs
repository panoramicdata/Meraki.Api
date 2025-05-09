namespace Meraki.Api.Data;

/// <summary>
/// Network attributes
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesProfileNetwork
{
	/// <summary>
	/// The ID of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}