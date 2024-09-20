namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers
/// </summary>
[DataContract]
public class EsimsServiceProviders
{
	/// <summary>
	/// Meta details about the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public EsimsServiceProvidersMeta Meta { get; set; } = new();

	/// <summary>
	/// List Cellular Service Providers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<EsimsServiceProvidersItem> Items { get; set; } = new();
}
