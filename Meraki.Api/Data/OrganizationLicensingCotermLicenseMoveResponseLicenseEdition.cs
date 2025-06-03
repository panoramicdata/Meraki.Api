namespace Meraki.Api.Data;

/// <summary>
/// An edition of the license for a product type
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveResponseLicenseEdition
{
	/// <summary>
	/// The name of the license edition
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "edition")]
	public string Edition { get; set; } = string.Empty;

	/// <summary>
	/// The product type of the license edition
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;
}