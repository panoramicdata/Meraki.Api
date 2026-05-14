namespace Meraki.Api.Data;

/// <summary>
/// Resolution metadata for order claim preview routing.
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResolution
{
	/// <summary>
	/// The synchronous submission path allowed for this preview.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "submissionStrategy")]
	public string? SubmissionStrategy { get; set; }

	/// <summary>
	/// Whether subscription selection is supported for this preview path.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "supportsSubscriptionSelection")]
	public bool? SupportsSubscriptionSelection { get; set; }

	/// <summary>
	/// The count of currently claimable shipped hardware devices.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "claimableShippedDeviceCount")]
	public int? ClaimableShippedDeviceCount { get; set; }
}