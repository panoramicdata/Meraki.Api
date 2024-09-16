namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Meta Counts Items
/// </summary>
[DataContract]
public class EsimsServiceProvidersMetaCountsItems
{
	/// <summary>
	/// Remaining number of Service Providers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// Total number of Service Providers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
