namespace Meraki.Api.Data;

/// <summary>
/// Type of Identity
/// </summary>
[DataContract]
public class OrganizationSecureConnectRemoteAccessLogDataItemIdentityType
{
	/// <summary>
	/// Identity type ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Identity type Label
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "label")]
	public string Label { get; set; } = string.Empty;

	/// <summary>
	/// Type of Identity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}