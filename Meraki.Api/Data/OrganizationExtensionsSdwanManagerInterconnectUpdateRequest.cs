namespace Meraki.Api.Data;

/// <summary>
/// Organization Extensions Sdwan Manager Interconnect Update Request
/// </summary>
[DataContract]
public class OrganizationExtensionsSdwanManagerInterconnectUpdateRequest
{
	/// <summary>
	/// Interconnect name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Interconnect status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
