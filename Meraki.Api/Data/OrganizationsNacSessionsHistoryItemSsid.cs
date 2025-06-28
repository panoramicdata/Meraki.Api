namespace Meraki.Api.Data;

/// <summary>
/// SSID Details
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryItemSsid
{
	/// <summary>
	/// SSID Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}