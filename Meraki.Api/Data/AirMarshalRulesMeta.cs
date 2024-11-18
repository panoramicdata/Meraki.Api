namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Rules Meta
/// </summary>
[DataContract]
public class AirMarshalRulesMeta
{
	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public AirMarshalRulesMetaCounts Counts { get; set; } = new();
}
