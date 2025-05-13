namespace Meraki.Api.Data;

/// <summary>
/// Organization Sm Bulk Enrollment Token Create Request
/// </summary>
[DataContract]
public class OrganizationSmBulkEnrollmentTokenCreateRequest
{
	/// <summary>
	/// The id of the associated node_group.
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The expiration date.
	/// </summary>
	[DataMember(Name = "expiresAt")]
	public string ExpiresAt { get; set; } = string.Empty;
}
