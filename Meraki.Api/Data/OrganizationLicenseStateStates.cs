namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states
/// </summary>
[DataContract]
public class OrganizationLicenseStateStates
{
	/// <summary>
	/// Data for active licenses
	/// </summary>
	[DataMember(Name = "active")]
	public OrganizationLicenseStateStatesActive Active { get; set; } = new();

	/// <summary>
	/// Data for expired licenses
	/// </summary>
	[DataMember(Name = "expired")]
	public OrganizationLicenseStateStatesExpired Expired { get; set; } = new();

	/// <summary>
	/// Data for expiring licenses
	/// </summary>
	[DataMember(Name = "expiring")]
	public OrganizationLicenseStateStatesExpiring Expiring { get; set; } = new();

	/// <summary>
	/// Data for recently queued licenses
	/// </summary>
	[DataMember(Name = "recentlyQueued")]
	public OrganizationLicenseStateStatesRecentlyQueued RecentlyQueued { get; set; } = new();

	/// <summary>
	/// Data for unused licenses
	/// </summary>
	[DataMember(Name = "unused")]
	public OrganizationLicenseStateStatesUnused Unused { get; set; } = new();

	/// <summary>
	/// Data for unused active licenses
	/// </summary>
	[DataMember(Name = "unusedActive")]
	public OrganizationLicenseStateStatesUnusedActive UnusedActive { get; set; } = new();
}
