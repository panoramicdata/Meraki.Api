namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsItem
	: ItemsResponseWithMeta<NetworkCellularGatewayEsimsServiceProviderAccount>
{
	/// <summary>
	/// List of Cellular Service Provider Accounts
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	public override List<NetworkCellularGatewayEsimsServiceProviderAccount> Items { get; set; } = [];
}
