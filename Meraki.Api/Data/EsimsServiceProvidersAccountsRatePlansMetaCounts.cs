namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Rate Plans Meta Counts
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsRatePlansMetaCounts
{
	/// <summary>
	///	Count of Rate Plans available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public EsimsServiceProvidersAccountsRatePlansMetaCountsItems Items { get; set; } = new();
}
