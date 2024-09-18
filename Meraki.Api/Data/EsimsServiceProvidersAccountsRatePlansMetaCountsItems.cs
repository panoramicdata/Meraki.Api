namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Rate Plans Meta Counts Items
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsRatePlansMetaCountsItems
{
	/// <summary>
	///	Remaining number of Rate Plans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	///	Total number of Rate Plans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
