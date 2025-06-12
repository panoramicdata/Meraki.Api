namespace Meraki.Api.Data;

/// <summary>
/// Network of the packet capture file
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileNetwork
{
	/// <summary>
	/// ID of network
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}