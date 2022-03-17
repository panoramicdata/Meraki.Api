namespace Meraki.Api.Data;
/// <summary>
/// Uplinks
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]

public class StackDeviceUplinks
{
	/// <summary>
	/// Vlan Id
	/// </summary>
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// PPPOE
	/// </summary>
	[DataMember(Name = "pppoe")]
	public StackDeviceUplinksPppoe Pppoe { get; set; } = new();
}
