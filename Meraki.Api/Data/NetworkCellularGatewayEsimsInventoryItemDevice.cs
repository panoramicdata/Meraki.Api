namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Item Device
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryItemDevice
{
	/// <summary>
	/// Device model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Device name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name	")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Device URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
