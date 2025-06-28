namespace Meraki.Api.Data;

/// <summary>
/// Identity Details
/// </summary>
[DataContract]
public class OrganizationSecureConnectRemoteAccessLogDataItemIdentity
{
	/// <summary>
	/// Identity ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Identity Label
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "label")]
	public string Label { get; set; } = string.Empty;

	/// <summary>
	/// Is the Identity already deleted
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deleted")]
	public bool Deleted { get; set; }

	/// <summary>
	/// Type of Identity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public OrganizationSecureConnectRemoteAccessLogDataItemIdentityType Type { get; set; } = new();
}
