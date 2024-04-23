namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states recently queued
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationLicenseStateStatesRecentlyQueued
{
	/// <summary>
	/// The number of recently queued licenses
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }
}
