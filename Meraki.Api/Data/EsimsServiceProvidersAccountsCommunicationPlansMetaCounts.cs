namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Communication Plans Meta Counts
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsCommunicationPlansMetaCounts
{
	/// <summary>
	///	Count of Communication Plans available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public EsimsServiceProvidersAccountsCommunicationPlansMetaCountsItems Items { get; set; } = new();
}
