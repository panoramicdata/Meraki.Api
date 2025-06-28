namespace Meraki.Api.Data;

/// <summary>
/// Network SSID Details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsNetworkSsid
{
	/// <summary>
	/// Network SSID Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}