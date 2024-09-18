namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Communication Plans
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsCommunicationPlans
{
	/// <summary>
	///	Meta details about the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public EsimsServiceProvidersAccountsCommunicationPlansMeta Meta { get; set; } = new();

	/// <summary>
	/// List of Cellular Service Provider Communication Plans
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<EsimsServiceProvidersAccountsCommunicationPlansItem> Items { get; set; } = new();

}
