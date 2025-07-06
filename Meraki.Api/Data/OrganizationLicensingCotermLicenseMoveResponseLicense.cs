namespace Meraki.Api.Data;

/// <summary>
/// Newly moved license created in the destination organization of the license move operation
/// </summary>
[DataContract]
public class OrganizationLicensingCotermLicenseMoveResponseLicense
{
	/// <summary>
	/// The duration (term length) of the license, measured in days
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "duration")]
	public int Duration { get; set; }

	/// <summary>
	/// When the license was claimed into the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "claimedAt")]
	public string ClaimedAt { get; set; } = string.Empty;

	/// <summary>
	/// When the license was invalidated. Will be null for active licenses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "invalidatedAt")]
	public string InvalidatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The key of the license
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "key")]
	public string Key { get; set; } = string.Empty;

	/// <summary>
	/// The operation mode of the license when it was claimed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public LicenseMode Mode { get; set; }

	/// <summary>
	/// The ID of the organization that the license is claimed in
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// When the license's term began (approximately the date when the license was created)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startedAt")]
	public string StartedAt { get; set; } = string.Empty;

	/// <summary>
	/// Flag to indicate if the license is expired
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expired")]
	public bool Expired { get; set; }

	/// <summary>
	/// Flag to indicated that the license is invalidated
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "invalidated")]
	public bool Invalidated { get; set; }

	/// <summary>
	/// The counts of the license by model type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public List<OrganizationLicensingCotermLicenseMoveResponseLicenseCount> Counts { get; set; } = [];

	/// <summary>
	/// The editions of the license for each relevant product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "editions")]
	public List<OrganizationLicensingCotermLicenseMoveResponseLicenseEdition> Editions { get; set; } = [];
}
