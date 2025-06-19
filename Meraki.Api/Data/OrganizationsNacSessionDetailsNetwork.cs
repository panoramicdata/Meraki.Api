namespace Meraki.Api.Data;

/// <summary>
/// Network details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsNetwork
{
	/// <summary>
	/// Network Access Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accessType")]
	public string AccessType { get; set; } = string.Empty;

	/// <summary>
	/// Network Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Network Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public string Tags { get; set; } = string.Empty;

	/// <summary>
	/// Network Port Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public OrganizationsNacSessionDetailsNetworkPort Port { get; set; } = new();

	/// <summary>
	/// Network SSID Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssid")]
	public OrganizationsNacSessionDetailsNetworkSsid Ssid { get; set; } = new();
}
