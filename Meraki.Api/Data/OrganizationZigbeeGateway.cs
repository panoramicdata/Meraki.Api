namespace Meraki.Api.Data;

/// <summary>
/// MR node the zigbee device is on
/// </summary>
[DataContract]
public class OrganizationZigbeeGateway
{
	/// <summary>
	/// The mac address of the MR node
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The name of the MR node
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The serial number of the MR node
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The tags assocated with the MR node
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}