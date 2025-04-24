namespace Meraki.Api.Data;

/// <summary>
/// Network of the switch
/// </summary>
public class DeviceSwitchPortMirrorNetwork
{
	/// <summary>
	/// ID of the network
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The name of the network
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}