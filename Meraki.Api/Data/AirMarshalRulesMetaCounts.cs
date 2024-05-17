namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Rules Meta Counts
/// </summary>
[DataContract]
public class AirMarshalRulesMetaCounts
{
	/// <summary>
	/// Items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public AirMarshalRulesMetaCountsItems Items { get; set; } = new();


}
