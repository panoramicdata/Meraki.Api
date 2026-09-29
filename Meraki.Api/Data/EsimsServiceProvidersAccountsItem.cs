namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts
/// </summary>
[Obsolete("Was the item type of EsimsServiceProvidersAccounts but is itself an {items, meta} wrapper, so no account ever bound. EsimsServiceProvidersAccounts.Items is now List<NetworkCellularGatewayEsimsServiceProviderAccount>. This type will be removed in a later release.")]
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
