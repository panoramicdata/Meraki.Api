namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Accounts Meta
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsMeta
{
	/// <summary>
	///	Counts of involved entities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public EsimsServiceProvidersAccountsMetaCounts Counts { get; set; } = new();

}
