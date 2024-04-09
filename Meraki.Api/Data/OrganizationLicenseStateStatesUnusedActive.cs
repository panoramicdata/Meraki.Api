namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states unused active
/// </summary>
[DataContract]
public class OrganizationLicenseStateStatesUnusedActive
{
	/// <summary>
	/// The number of unused licenses
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Information about the oldest historical license activation
	/// </summary>
	[DataMember(Name = "oldestActivation")]
	public OrganizationLicenseStateStatesUnusedActiveOldestActivation OldestActivation { get; set; } = new();
}
