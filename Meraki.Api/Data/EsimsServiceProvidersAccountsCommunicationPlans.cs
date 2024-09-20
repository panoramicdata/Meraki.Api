namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Communication Plans
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsCommunicationPlans
	: ItemsResponseWithMeta<EsimsServiceProvidersAccountsCommunicationPlansItem>
{
	/// <summary>
	/// List of Cellular Service Provider Communication Plans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	public override List<EsimsServiceProvidersAccountsCommunicationPlansItem> Items { get; set; } = [];
}
