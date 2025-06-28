namespace Meraki.Api.Data;

/// <summary>
/// Source port configuration for the rule.
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponseAclSourcePort
{
	/// <summary>
	/// Specifies what operator to use while checking if the protocol port matches the given port(s). enum = ["any", "equals", "greaterThan", "lesserThan", "notEquals", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "operator")]
	public string Operator { get; set; } = string.Empty;

	/// <summary>
	/// When the operator is "lesserThan" or "greaterThan" then the port list will have one entry for the operator. When the operator is "range" then port list will have two values with the range being between the values. When the operator is "equals" and "notEquals", then there may be any number of ports. When the operator is "any", then the port property will not be present.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<int> Ports { get; set; } = [];
}