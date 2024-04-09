namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states active
/// </summary>
[DataContract]
public class OrganizationLicenseStateStatesActive
{
	/// <summary>
	/// The number of active licenses
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

}
