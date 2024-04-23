namespace Meraki.Api.Data;

[DataContract]
public class AlertFiltersCondition
{
	/// <summary>
	/// Duration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "duration")]
	public int? Duration { get; set; }

	/// <summary>
	/// Direction
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "direction")]
	public AlertFiltersConditionDirection? Direction { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Unit
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "unit")]
	public string? Unit { get; set; }

	/// <summary>
	/// Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "threshold")]
	public double? Threshold { get; set; }
}