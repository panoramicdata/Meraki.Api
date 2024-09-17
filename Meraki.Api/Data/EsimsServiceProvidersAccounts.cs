namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccounts
{
	/// <summary>
	///	Meta details about the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public EsimsServiceProvidersAccountsMeta Meta { get; set; } = new();

	/// <summary>
	/// List of Cellular Service Provider Accounts
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<EsimsServiceProvidersAccountsItem> Items { get; set; } = new();

}
