namespace Meraki.Api.Data;

/// <summary>
/// Networks Switch Stack Ports Mirror
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirror
{
	/// <summary>
	/// Id of switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switchStackId")]
	public string SwitchStackId { get; set; } = string.Empty;

	/// <summary>
	/// Warnings from traffic mirror configuration changes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warnings")]
	public List<string> Warnings { get; set; } = [];

	/// <summary>
	/// Switch port mirror configurations
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mirror")]
	public NetworksSwitchStackPortsMirrorConfigurations Mirror { get; set; } = new();

	/// <summary>
	/// Network of the switch stack
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public NetworksSwitchStackPortsMirrorNetwork Network { get; set; } = new();
}
