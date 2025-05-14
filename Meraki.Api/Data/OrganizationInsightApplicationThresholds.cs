namespace Meraki.Api.Data;

/// <summary>
/// Thresholds defined by a user or Meraki models for each application
/// </summary>
[DataContract]
public class OrganizationInsightApplicationThresholds
{
	/// <summary>
	/// Threshold type (static or smart)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Threshold for each network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byNetwork")]
	public List<OrganizationInsightApplicationThresholdsByNetworkItem> ByNetwork { get; set; } = [];
}
