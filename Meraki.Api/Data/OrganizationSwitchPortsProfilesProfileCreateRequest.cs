namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Profile Create Request
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesProfileCreateRequest
{
	/// <summary>
	/// Text describing the profile
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The name of the profile
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The network identifier
	/// </summary>
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// The scope of the profile whether it is organization level or network level
	/// </summary>
	[DataMember(Name = "isOrganizationWide")]
	public bool? IsOrganizationWide { get; set; }

	/// <summary>
	/// Space-seperated list of tags
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// The networks which are included/excluded in the profile
	/// </summary>
	[DataMember(Name = "networks")]
	public OrganizationSwitchPortsProfilesProfileNetworks? Networks { get; set; }

	/// <summary>
	/// Configuration settings for port profile
	/// </summary>
	[DataMember(Name = "port")]
	public OrganizationSwitchPortsProfilesProfilePort? Port { get; set; }
}
