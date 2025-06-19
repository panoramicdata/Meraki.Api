namespace Meraki.Api.Data;

/// <summary>
/// Organization Insight Application Create Request
/// </summary>
[DataContract]
public class OrganizationInsightApplicationCreateRequest
{
	/// <summary>
	/// The id of the counter set rule
	/// </summary>
	[DataMember(Name = "counterSetRuleId")]
	public int CounterSetRuleId { get; set; }

	/// <summary>
	/// Enable Smart Thresholds
	/// </summary>
	[DataMember(Name = "enableSmartThresholds")]
	public bool? EnableSmartThresholds { get; set; }

	/// <summary>
	/// Thresholds defined by a user for each application
	/// </summary>
	[DataMember(Name = "thresholds")]
	public OrganizationInsightApplicationCreateRequestThresholds? Thresholds { get; set; }
}
