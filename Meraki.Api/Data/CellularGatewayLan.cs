namespace Meraki.Api.Data;

/// <summary>
/// Cellular Gateway Lan
/// </summary>
[DataContract]
public class CellularGatewayLan : CellularGatewayLanUpdateRequest
{
	/// <summary>
	/// name of the MG
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceName")]
	public string DeviceName { get; set; } = string.Empty;

	/// <summary>
	/// deviceLanIp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceLanIp")]
	public string DeviceLanIp { get; set; } = string.Empty;

	/// <summary>
	/// deviceSubnet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceSubnet")]
	public string DeviceSubnet { get; set; } = string.Empty;
}
