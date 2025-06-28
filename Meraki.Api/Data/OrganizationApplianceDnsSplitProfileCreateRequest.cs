namespace Meraki.Api.Data;

/// <summary>
/// Organizations Appliance Dns Split Profile Create Request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfileCreateRequest
{
	/// <summary>
	/// Name of profile
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The hostname patterns to match for redirection. For more information on Split DNS hostname pattern formatting, please consult the Split DNS KB.
	/// </summary>
	[DataMember(Name = "hostnames")]
	public List<string> Hostnames { get; set; } = [];

	/// <summary>
	/// Contains the nameserver information for redirection.
	/// </summary>
	[DataMember(Name = "nameservers")]
	public OrganizationApplianceDnsSplitProfileNameservers Nameservers { get; set; } = new();
}
