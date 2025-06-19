namespace Meraki.Api.Data;

/// <summary>
/// Client.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesSignalQualityClient
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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;
}