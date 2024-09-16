namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Meta
/// </summary>
[DataContract]
public class EsimsServiceProvidersMeta
{
	/// <summary>
	/// Counts of involved entities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public EsimsServiceProvidersMetaCounts Counts { get; set; } = new();

}
