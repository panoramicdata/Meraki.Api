namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Rules
/// </summary>
[DataContract]
public class AirMarshalRules
{
	/// <summary>
	/// Meta details about the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public AirMarshalRulesMeta Meta { get; set; } = new();

	/// <summary>
	/// List of rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<AirMarshalRulesItem> Items { get; set; } = [];

}
