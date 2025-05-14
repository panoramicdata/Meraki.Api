namespace Meraki.Api.Data;

/// <summary>
/// Destination port module details
/// </summary>
[DataContract]
public class DeviceSwitchPortsMirrorPortModule
{
	/// <summary>
	/// Slot number of the module which will act as source port
	/// </summary>
	[DataMember(Name = "slot")]
	public int? Slot { get; set; }

	/// <summary>
	/// Module type of the switch
	/// </summary>
	[DataMember(Name = "type")]
	public string? Type { get; set; }
}