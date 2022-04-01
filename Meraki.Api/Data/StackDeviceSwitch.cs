namespace Meraki.Api.Data;
/// <summary>
/// Switch
/// </summary>
[DataContract]

public class StackDeviceSwitch
{
	/// <summary>
	/// Ports
	/// </summary>
	[DataMember(Name = "ports")]
	public StackDeviceSwitchPorts Ports { get; set; } = new();
}
