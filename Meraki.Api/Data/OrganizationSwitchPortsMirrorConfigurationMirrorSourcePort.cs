namespace Meraki.Api.Data;

/// <summary>
/// Source Port config details
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorConfigurationMirrorSourcePort
{
	/// <summary>
	/// Source switch port number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// Source port module details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public OrganizationSwitchPortsMirrorConfigurationMirrorSourcePortModule Module { get; set; } = new();
}
