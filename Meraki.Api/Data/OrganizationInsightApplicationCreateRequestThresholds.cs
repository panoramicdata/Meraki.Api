namespace Meraki.Api.Data;

/// <summary>
/// Thresholds defined by a user for each application
/// </summary>
[DataContract]
public class OrganizationInsightApplicationCreateRequestThresholds
{
	/// <summary>
	/// Number of useful information bits delivered over a network per unit of time
	/// </summary>
	[DataMember(Name = "goodput")]
	public int Goodput { get; set; }

	/// <summary>
	/// Duration of the response, in milliseconds
	/// </summary>
	[DataMember(Name = "responseTime")]
	public int ResponseTime { get; set; }
}