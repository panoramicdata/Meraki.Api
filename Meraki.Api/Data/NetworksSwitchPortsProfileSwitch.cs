namespace Meraki.Api.Data;

/// <summary>
/// Switch details
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileSwitch
{
	/// <summary>
	/// The serial of the switch
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Create)]
	public string? Serial { get; set; }
}
