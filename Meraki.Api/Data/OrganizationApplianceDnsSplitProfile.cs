namespace Meraki.Api.Data;

/// <summary>
/// Organizations Appliance Dns Split Profile
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfile
{
	/// <summary>
	/// Name of profile
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Profile ID
	/// </summary>
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;

	/// <summary>
	/// The hostname patterns to match for redirection. For more information on Split DNS hostname pattern formatting, please consult the Split DNS KB.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "hostnames")]
	public List<string> Hostnames { get; set; } = [];

	/// <summary>
	/// Contains the nameserver information for redirection.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "nameservers")]
	public OrganizationApplianceDnsSplitProfileNameservers Nameservers { get; set; } = new();
}
