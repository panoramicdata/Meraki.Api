namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Rate Plans
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsRatePlans
{
	/// <summary>
	///	Meta details about the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public EsimsServiceProvidersAccountsRatePlansMeta Meta { get; set; } = new();

	/// <summary>
	/// List of Cellular Service Provider Communication Plans
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<EsimsServiceProvidersAccountsRatePlansItem> Items { get; set; } = new();

}
