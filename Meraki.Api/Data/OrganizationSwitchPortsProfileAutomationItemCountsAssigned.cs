namespace Meraki.Api.Data;

/// <summary>
/// Count of assigned devices, ports, networks to a automation profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemCountsAssigned
{
	/// <summary>
	/// Count of devices assigned to the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public int Devices { get; set; }

	/// <summary>
	/// Count of networks assigned to the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networks")]
	public int Networks { get; set; }

	/// <summary>
	/// Count of ports assigned to the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public int Ports { get; set; }
}