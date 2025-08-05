namespace Meraki.Api.Data;

/// <summary>
/// Client details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsClient
{
	/// <summary>
	/// Device Profiling
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceProfiling")]
	public string DeviceProfiling { get; set; } = string.Empty;

	/// <summary>
	/// Client Groups
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groups")]
	public string Groups { get; set; } = string.Empty;

	/// <summary>
	/// GUID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "guid")]
	public string ClientGuid { get; set; } = string.Empty;

	/// <summary>
	/// Client Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Client IP Address Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationsNacSessionDetailsClientAddress> Addresses { get; set; } = [];
}
