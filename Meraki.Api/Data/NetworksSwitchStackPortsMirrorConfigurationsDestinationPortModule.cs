namespace Meraki.Api.Data;

/// <summary>
/// Destination port module object
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorConfigurationsDestinationPortModule
{
	/// <summary>
	/// Destination switch module type slot number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "slot")]
	public int Slot { get; set; }

	/// <summary>
	/// Destination switch module type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}