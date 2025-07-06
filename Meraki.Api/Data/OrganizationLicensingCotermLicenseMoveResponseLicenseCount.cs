namespace Meraki.Api.Data;

/// <summary>
/// Counts of the license by model type
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveResponseLicenseCount
{
	/// <summary>
	/// The number of counts the license contains of this model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// The license model type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;
}