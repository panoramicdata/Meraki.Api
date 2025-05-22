namespace Meraki.Api.Data;

/// <summary>
/// Organization Sm Bulk Enrollment Token
/// </summary>
[DataContract]
public class OrganizationSmBulkEnrollmentTokenDetailed
{
	/// <summary>
	/// The expiration date.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expiresAt")]
	public string ExpiresAt { get; set; } = string.Empty;

	/// <summary>
	/// The token id.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The network id of the associated node_group.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The raw token the user will input into the agent.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rawToken")]
	public string RawToken { get; set; } = string.Empty;
}
