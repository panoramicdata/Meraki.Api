namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Communication Plans Meta Counts Items
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsCommunicationPlansMetaCountsItems
{
	/// <summary>
	///	Remaining number of Communication Plans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	///	Total number of Communication Plans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
