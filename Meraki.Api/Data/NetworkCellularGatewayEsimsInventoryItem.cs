namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Item
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryItem
{
	/// <summary>
	/// eSIM EID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	[DataMember(Name = "eid")]
	public string Eid { get; set; } = string.Empty;

	/// <summary>
	/// Last update of eSIM
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public string lastUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Whether eSIM is currently active SIM on Device
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "active")]
	public bool Active { get; set; }

	/// <summary>
	/// Meraki Device properties
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "device")]
	public NetworkCellularGatewayEsimsInventoryItemDevice Device { get; set; } = new();

	/// <summary>
	/// Meraki Network properties
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "network")]
	public NetworkCellularGatewayEsimsInventoryItemNetwork Network { get; set; } = new();

	/// <summary>
	/// eSIM Profile Information
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "profiles")]
	public List<NetworkCellularGatewayEsimsInventoryItemProfile> Profiles { get; set; } = [];
}
