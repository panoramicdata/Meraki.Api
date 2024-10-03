namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Service Provider Account Create Request
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsServiceProviderAccountCreateRequest
{
	/// <summary>
	/// Service provider account ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accountId")]
	public string AccountId { get; set; } = string.Empty;

	/// <summary>
	/// Service provider account API key
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "apiKey")]
	public string ApiKey { get; set; } = string.Empty;

	/// <summary>
	/// Service provider account name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "title")]
	public string? Title { get; set; }

	/// <summary>
	/// Service provider account username
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "username")]
	public string? Username { get; set; }

	/// <summary>
	/// Service provider data.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "serviceProvider")]
	public NetworkCellularGatewayEsimsServiceProviderAccountServiceProvider? ServiceProvider { get; set; }
}
