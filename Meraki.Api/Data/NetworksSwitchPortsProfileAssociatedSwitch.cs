namespace Meraki.Api.Data;

/// <summary>
/// A switch associated with the port profile
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileAssociatedSwitch
{
	/// <summary>
	/// The ID of the switch
	/// </summary>
	[DataMember(Name = "switchId")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public long? SwitchId { get; set; }

	/// <summary>
	/// The name of the switch
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Name { get; set; }

	/// <summary>
	/// The mac address of the switch
	/// </summary>
	[DataMember(Name = "mac")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Mac { get; set; }

	/// <summary>
	/// The serial of the switch
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Serial { get; set; }

	/// <summary>
	/// The model of the switch
	/// </summary>
	[DataMember(Name = "model")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? Model { get; set; }
}
