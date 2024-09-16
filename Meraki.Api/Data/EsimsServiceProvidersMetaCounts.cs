namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Meta Counts
/// </summary>
[DataContract]
public class EsimsServiceProvidersMetaCounts
{
	/// <summary>
	/// Service Providers available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public EsimsServiceProvidersMetaCountsItems Items { get; set; } = new();

}
