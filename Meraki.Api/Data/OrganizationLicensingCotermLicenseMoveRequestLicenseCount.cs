namespace Meraki.Api.Data;

/// <summary>
/// A count to move from license by model type
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveRequestLicenseCount
{
	/// <summary>
	/// The number of counts to move
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// The license model type to move counts of
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;
}