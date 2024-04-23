namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states expiring warning
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationLicenseStateStatesExpiringWarning
{
	/// <summary>
	/// The number of licenses that will expire in this window
	/// </summary>
	[DataMember(Name = "expiringCount")]
	public int ExpiringCount { get; set; }

	/// <summary>
	/// The number of days from now denoting the warning threshold for an expiring license
	/// </summary>
	[DataMember(Name = "thresholdInDays")]
	public int ThresholdInDays { get; set; }
}
