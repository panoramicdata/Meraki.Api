namespace Meraki.Api.Data;

/// <summary>
/// License by model type count.
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseCount
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