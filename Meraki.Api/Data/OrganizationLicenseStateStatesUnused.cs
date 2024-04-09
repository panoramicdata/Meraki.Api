namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states unused
/// </summary>
[DataContract]
public class OrganizationLicenseStateStatesUnused
{
	/// <summary>
	/// The number of unused licenses
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Information about the soonest forthcoming license activation
	/// </summary>
	[DataMember(Name = "soonestActivation")]
	public OrganizationLicenseStateStatesUnusedSoonestActivation SoonestActivation { get; set; } = new();
}
