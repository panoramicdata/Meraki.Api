namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Rules Item
/// </summary>
[DataContract]
public class AirMarshalRulesItem
{
	/// <summary>
	/// Created at timestamp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Rule id
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ruleId")]
	public string RuleId { get; set; } = string.Empty;

	/// <summary>
	/// The action for SSIDs that match: "allow", "block" or "alert"
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Updated at timestamp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public DateTime UpdatedAt { get; set; }

	/// <summary>
	/// Match
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "match")]
	public AirMarshalRulesItemMatch Match { get; set; } = new();

	/// <summary>
	/// Network details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public AirMarshalRulesItemNetwork Network { get; set; } = new();
}
