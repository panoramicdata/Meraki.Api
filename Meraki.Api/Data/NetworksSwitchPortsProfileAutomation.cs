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
	public string? Id { get; set; }

	/// <summary>
	/// The name of the associated automation
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
