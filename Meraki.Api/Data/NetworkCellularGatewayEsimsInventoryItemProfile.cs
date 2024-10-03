namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Inventory Item Profile
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsInventoryItemProfile
{
	/// <summary>
	/// eSIM profile ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	[DataMember(Name = "iccid")]
	public string Iccid { get; set; } = string.Empty;

	/// <summary>
	/// eSIM profile status
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Available custom APNs for the profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "customApns")]
	public List<string> CustomApns { get; set; } = [];

	/// <summary>
	/// Service Provider information
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serviceProvider")]
	public NetworkCellularGatewayEsimsInventoryItemProfileServiceProvider ServiceProvider { get; set; } = new();
}
