namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers
/// </summary>
[DataContract]
public class EsimsServiceProviders
	: ItemsResponseWithMeta<EsimsServiceProvidersItem>
{
	/// <summary>
	/// List Cellular Service Providers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<EsimsServiceProvidersItem> Items { get; set; } = [];
}
