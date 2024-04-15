namespace Meraki.Api.Data;

[DataContract]
public class AlertFiltersCondition
{
	/// <summary>
	/// Duration
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "duration")]
	public int? Duration { get; set; }

	/// <summary>
	/// Direction
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "direction")]
	public AlertFiltersConditionDirection? Direction { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Unit
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "unit")]
	public string? Unit { get; set; }

	/// <summary>
	/// Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "threshold")]
	public double? Threshold { get; set; }
}