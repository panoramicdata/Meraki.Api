namespace Meraki.Api.Data;

/// <summary>
/// Organization Zigbee Device
/// </summary>
[DataContract]
public class OrganizationZigbeeDevice
{
	/// <summary>
	/// Power level for the zigbee devices will be a int between 10-20
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "transmitPowerLevel")]
	public int TransmitPowerLevel { get; set; }

	/// <summary>
	/// Channel the zigbee node will communicate on either auto or between 11-25
	/// </summary>
	[DataMember(Name = "channel")]
	public string Channel { get; set; } = string.Empty;

	/// <summary>
	/// Unique id for the zigbee device node
	/// </summary>
	[DataMember(Name = "panId")]
	public string PanId { get; set; } = string.Empty;

	/// <summary>
	/// The Node status, either online or offline.
	/// </summary>
	[DataMember(Name = "status")]
	public NodeStatus Status { get; set; }

	/// <summary>
	/// Whether this Node is enrolled or not
	/// </summary>
	[DataMember(Name = "enrolled")]
	public bool Enrolled { get; set; }

	/// <summary>
	/// Stats
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationZigbeeCounts Counts { get; set; } = new();

	/// <summary>
	/// MR node the zigbee device is on
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "gateway")]
	public OrganizationZigbeeGateway Gateway { get; set; } = new();

	/// <summary>
	/// Network zigbee device is on
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationZigbeeNetworkDetailed Network { get; set; } = new();
}
