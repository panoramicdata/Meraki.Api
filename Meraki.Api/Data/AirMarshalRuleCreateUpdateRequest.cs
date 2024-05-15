namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Rule Update Request
/// </summary>
[DataContract]
public class AirMarshalRuleCreateUpdateRequest
{
	/// <summary>
	/// Indicates if this rule will allow, block, or alert.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Object describing the rule specification.
	/// </summary>
	[DataMember(Name = "match")]
	public AirMarshalRulesItemMatch? Match { get; set; }

}
