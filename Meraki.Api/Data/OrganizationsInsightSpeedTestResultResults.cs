namespace Meraki.Api.Data;

/// <summary>
/// Ping request results
/// </summary>
[DataContract]
public class OrganizationsInsightSpeedTestResultResults
{
	/// <summary>
	/// Speed test results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speeds")]
	public OrganizationsInsightSpeedTestResultResultsSpeeds Speeds { get; set; } = new();
}
