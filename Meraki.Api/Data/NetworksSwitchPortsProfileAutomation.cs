namespace Meraki.Api.Data;

/// <summary>
/// Associated Automation
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileAutomation
{
	/// <summary>
	/// The ID of the associated automation
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Id { get; set; }

	/// <summary>
	/// The name of the associated automation
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }
}
