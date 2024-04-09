namespace Meraki.Api.Data;

/// <summary>
/// An organization licence state states expired
/// </summary>
[DataContract]
public class OrganizationLicenseStateStatesExpired
{
	/// <summary>
	/// The number of expired licenses
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

}
