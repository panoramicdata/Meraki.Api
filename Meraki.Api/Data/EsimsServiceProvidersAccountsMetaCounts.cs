namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Accounts Meta Counts
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsMetaCounts
{
	/// <summary>
	///	Count of Cellular Service Providers available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public EsimsServiceProvidersAccountsMetaCountsItems Items { get; set; } = new();

}
