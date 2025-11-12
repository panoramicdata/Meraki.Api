namespace Meraki.Api.Data;

/// <summary>
/// Appliance Utilization Summary Network
/// </summary>
[DataContract]
public class ApplianceUtilizationSummaryNetwork
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
