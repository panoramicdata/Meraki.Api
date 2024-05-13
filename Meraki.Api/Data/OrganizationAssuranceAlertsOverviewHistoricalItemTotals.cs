namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertsOverviewHistoricalItemTotals
{
	/// <summary>
	/// Critical Severity Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "critical")]
	public int Critical { get; set; }

	/// <summary>
	/// Informational Severity Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "informational")]
	public int Informational { get; set; }

	/// <summary>
	/// Warning Severity Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warning")]
	public int Warning { get; set; }
}
