namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports By Switch
/// </summary>
[DataContract]
public class SwitchPortsBySwitch : NamedItem
{
	/// <summary>
	/// Switch Serial Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Switch Mac Address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public SwitchPortsBySwitchNetwork Network { get; set; } = new();

	/// <summary>
	/// Switch Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Switch Ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<SwitchPort> Ports { get; set; } = [];
}
