namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esims Service Provider Account
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimsServiceProviderAccount
{
	/// <summary>
	/// Service provider account ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accountId")]
	public string AccountId { get; set; } = string.Empty;

	/// <summary>
	/// Last updated at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public string LastUpdatedAt { get; set; } = string.Empty;

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
