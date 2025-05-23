namespace Meraki.Api.Data;

/// <summary>
/// Network
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSignalQualityNetwork
{
	/// <summary>
	/// Client ID.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// MAC address.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
