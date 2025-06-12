namespace Meraki.Api.Data;

/// <summary>
/// Speed test results
/// </summary>
[DataContract]
public class OrganizationsInsightSpeedTestResultResultsSpeeds
{
	/// <summary>
	/// Average speed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }
}