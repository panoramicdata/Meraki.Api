namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Rules Meta Counts
/// </summary>
[DataContract]
public class AirMarshalRulesMetaCountsItems
{
	/// <summary>
	/// Remaining number of rules
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// Count of rules
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
