namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Accounts Meta Counts Items
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsMetaCountsItems
{
	/// <summary>
	///	Remaining number of Cellular Service Providers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	///	Total number of Cellular Service Providers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
