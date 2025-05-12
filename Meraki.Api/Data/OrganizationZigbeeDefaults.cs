namespace Meraki.Api.Data;

/// <summary>
/// Default Settings for the MRs in network
/// </summary>
[DataContract]
public class OrganizationZigbeeDefaults
{
	/// <summary>
	/// Default Transmit Power Level for the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "transmitPowerLevel")]
	public int TransmitPowerLevel { get; set; }

	/// <summary>
	/// Channel the zigbee node will communicate on either, auto or between 11-25
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "channel")]
	public string Channel { get; set; } = string.Empty;
}