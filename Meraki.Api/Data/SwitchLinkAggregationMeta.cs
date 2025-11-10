namespace Meraki.Api.Data;

/// <summary>
/// Metadata for switch link aggregation
/// </summary>
[DataContract]
public class SwitchLinkAggregationMeta
{
	/// <summary>
	/// The ID of the switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switchStackId")]
	public string? SwitchStackId { get; set; }

	/// <summary>
	/// The aggregation ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "aggrId")]
	public string? AggrId { get; set; }
}
