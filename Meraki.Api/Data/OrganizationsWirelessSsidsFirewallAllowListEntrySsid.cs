namespace Meraki.Api.Data;

/// <summary>
/// The SSID that allowlist belongs to
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListEntrySsid
{
	/// <summary>
	/// The number of SSID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// The index of SSID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}