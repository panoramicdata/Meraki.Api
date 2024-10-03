namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Service Provider Account Update Request
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsServiceProviderAccountUpdateRequest
{
	/// <summary>
	/// Service provider account API key
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "apiKey")]
	public string? ApiKey { get; set; }

	/// <summary>
	/// Service provider account name used on the Meraki UI
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "title")]
	public string? Title { get; set; }
}
