namespace Meraki.Api.Data;

/// <summary>
/// Destination port config details
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestDestinationPort
{
	/// <summary>
	/// Destination switch port number
	/// </summary>
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// Destination port module details
	/// </summary>
	[DataMember(Name = "module")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestDestinationPortModule? Module { get; set; }
}
