namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccounts
	: ItemsResponseWithMeta<EsimsServiceProvidersAccountsItem>
{
	/// <summary>
	/// List of Cellular Service Provider Accounts
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	public override List<EsimsServiceProvidersAccountsItem> Items { get; set; } = [];
}
