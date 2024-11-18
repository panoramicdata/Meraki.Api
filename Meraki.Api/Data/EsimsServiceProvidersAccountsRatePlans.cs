namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Rate Plans
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsRatePlans
	: ItemsResponseWithMeta<EsimsServiceProvidersAccountsRatePlansItem>
{
	/// <summary>
	/// List of ESIMs Service Provider Accounts Rate Plans
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	public override List<EsimsServiceProvidersAccountsRatePlansItem> Items { get; set; } = [];
}
