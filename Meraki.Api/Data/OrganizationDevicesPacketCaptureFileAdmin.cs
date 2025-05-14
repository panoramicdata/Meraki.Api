namespace Meraki.Api.Data;

/// <summary>
/// Admin who created the packet capture file
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileAdmin
{
	/// <summary>
	/// ID of admin
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the admin
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}