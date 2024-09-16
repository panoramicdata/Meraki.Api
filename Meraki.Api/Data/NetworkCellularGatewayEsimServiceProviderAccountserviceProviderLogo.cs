namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Service Provider Account Service Provider Logo
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsServiceProviderAccountServiceProviderLogo
{
	/// <summary>
	/// Service Provider logo url.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }
}
