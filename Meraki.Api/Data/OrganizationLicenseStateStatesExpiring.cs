namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states expiring
/// </summary>
[DataContract]
public class OrganizationLicenseStateStatesExpiring
{
	/// <summary>
	/// The number of expiring licenses
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Data for the critical threshold
	/// </summary>
	[DataMember(Name = "critical")]
	public OrganizationLicenseStateStatesExpiringCritical Critical { get; set; } = new();

	/// <summary>
	/// Data for the warning threshold
	/// </summary>
	[DataMember(Name = "warning")]
	public OrganizationLicenseStateStatesExpiringWarning Warning { get; set; } = new();
}
