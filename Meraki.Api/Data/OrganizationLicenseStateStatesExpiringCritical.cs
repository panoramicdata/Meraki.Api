namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states expiring critical
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationLicenseStateStatesExpiringCritical
{
	/// <summary>
	/// The number of licenses that will expire in this window
	/// </summary>
	[DataMember(Name = "expiringCount")]
	public int ExpiringCount { get; set; }

	/// <summary>
	/// The number of days from now denoting the critical threshold for an expiring license
	/// </summary>
	[DataMember(Name = "thresholdInDays")]
	public int ThresholdInDays { get; set; }
}
