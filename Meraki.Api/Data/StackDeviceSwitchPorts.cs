namespace Meraki.Api.Data;
/// <summary>
/// Ports
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class StackDeviceSwitchPorts
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public StackDeviceSwitchPortsCounts Counts { get; set; } = new();
}
