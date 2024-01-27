namespace Meraki.Api.Data;

/// <summary>
/// Operator
/// </summary>
[DataContract]
public class HotspotOperator
{
	/// <summary>
	/// Operator name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
