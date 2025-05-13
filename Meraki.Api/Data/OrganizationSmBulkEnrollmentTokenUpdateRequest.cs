namespace Meraki.Api.Data;

/// <summary>
/// Organization Sm Bulk Enrollment Token Update Request
/// </summary>
[DataContract]
public class OrganizationSmBulkEnrollmentTokenUpdateRequest
{
	/// <summary>
	/// The expiration date.
	/// </summary>
	[DataMember(Name = "expiresAt")]
	public string? ExpiresAt { get; set; }

	/// <summary>
	/// The id of the associated node_group.
	/// </summary>
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }
}
