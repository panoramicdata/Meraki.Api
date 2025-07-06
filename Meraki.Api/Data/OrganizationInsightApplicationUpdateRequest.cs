namespace Meraki.Api.Data;

/// <summary>
/// Organization Insight Application Update Request
/// </summary>
[DataContract]
public class OrganizationInsightApplicationUpdateRequest
{
	/// <summary>
	/// Enable Smart Thresholds
	/// </summary>
	[DataMember(Name = "enableSmartThresholds")]
	public bool? EnableSmartThresholds { get; set; }

	/// <summary>
	/// Thresholds defined by a user for each application
	/// </summary>
	[DataMember(Name = "thresholds")]
	public OrganizationInsightApplicationUpdateRequestThresholds? Thresholds { get; set; }
}
