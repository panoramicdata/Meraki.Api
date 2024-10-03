namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Rate Plans Item
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsRatePlansItem
{
	/// <summary>
	///	Account ID of plans to be fetched
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accountId")]
	public string AccountId { get; set; } = string.Empty;

	/// <summary>
	/// Rate plan name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
