namespace Meraki.Api.Data;

/// <summary>
/// Organizations Insight Speed Test Result
/// </summary>
[DataContract]
public class OrganizationsInsightSpeedTestResult
{
	/// <summary>
	/// Network identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// SpeedTest result identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speedTestId")]
	public string SpeedTestId { get; set; } = string.Empty;

	/// <summary>
	/// Time when the test started
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startedAt")]
	public string StartedAt { get; set; } = string.Empty;

	/// <summary>
	/// Ping request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public OrganizationsInsightSpeedTestResultRequest Request { get; set; } = new();

	/// <summary>
	/// Ping request results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "results")]
	public OrganizationsInsightSpeedTestResultResults Results { get; set; } = new();
}
