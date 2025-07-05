namespace Meraki.Api.Data;

/// <summary>
/// Contains the nameserver information for redirection
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfileNameservers
{
	/// <summary>
	/// The nameserver address(es) to use for redirection. A maximum of one address is supported.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "addresses")]
	public List<string> Addresses { get; set; } = [];
}