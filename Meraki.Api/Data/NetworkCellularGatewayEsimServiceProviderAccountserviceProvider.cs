namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Service Provider Account Service Provider
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsServiceProviderAccountServiceProvider
{
	/// <summary>
	/// Name of the service provider.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Service provider logo data.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "logo")]
	public NetworkCellularGatewayEsimsServiceProviderAccountServiceProviderLogo? Logo { get; set; }
}
