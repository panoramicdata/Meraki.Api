namespace Meraki.Api.Data;

/// <summary>
/// Client of the packet capture file
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileClient
{
	/// <summary>
	/// Client ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Client MAC address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;
}
