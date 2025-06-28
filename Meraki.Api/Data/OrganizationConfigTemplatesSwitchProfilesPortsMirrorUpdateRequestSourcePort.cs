namespace Meraki.Api.Data;

/// <summary>
/// source port config details
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestSourcePort
{
	/// <summary>
	/// Source switch port number
	/// </summary>
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// Source port module details
	/// </summary>
	[DataMember(Name = "module")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateRequestSourcePortModule? Module { get; set; }
}
