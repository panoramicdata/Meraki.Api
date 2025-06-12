namespace Meraki.Api.Data;

/// <summary>
/// The status of layer 2 interfaces of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDeviceGetResponseItemInterfaceChange
{
	/// <summary>
	/// The status of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The timestamp of current status of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// All errors present on the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = [];

	/// <summary>
	/// All warnings present on the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warnings")]
	public List<string> Warnings { get; set; } = [];
}