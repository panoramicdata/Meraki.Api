namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Rate Plans Meta
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsRatePlansMeta
{
	/// <summary>
	///	Counts of involved entities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public EsimsServiceProvidersAccountsRatePlansMetaCounts Counts { get; set; } = new();
}
