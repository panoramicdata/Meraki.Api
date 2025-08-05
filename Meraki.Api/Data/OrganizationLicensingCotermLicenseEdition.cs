namespace Meraki.Api.Data;

/// <summary>
/// Edition of a license for a specific product type.
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseEdition
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