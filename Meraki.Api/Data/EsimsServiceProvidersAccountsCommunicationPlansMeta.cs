namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Communication Plans Meta
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsCommunicationPlansMeta
{
	/// <summary>
	///	Counts of involved entities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public EsimsServiceProvidersAccountsCommunicationPlansMetaCounts Counts { get; set; } = new();
}
