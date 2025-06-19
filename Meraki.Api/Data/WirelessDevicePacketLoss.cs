namespace Meraki.Api.Data;

/// <summary>
/// Represents packet loss statistics for a wireless device in an organization.
/// </summary>
[DataContract]
public class WirelessDevicePacketLoss
{
	/// <summary>
	/// Downstream packet loss statistics.
	/// </summary>
	[DataMember(Name = "downstream")]
	public PacketLossStats? Downstream { get; set; }

	/// <summary>
	/// Upstream packet loss statistics.
	/// </summary>
	[DataMember(Name = "upstream")]
	public PacketLossStats? Upstream { get; set; }

	/// <summary>
	/// Network information for the device.
	/// </summary>
	[DataMember(Name = "network")]
	public NetworkInfo? Network { get; set; }

	/// <summary>
	/// Device information.
	/// </summary>
	[DataMember(Name = "device")]
	public DeviceInfo? Device { get; set; }
}

/// <summary>
/// Represents packet loss statistics for a direction (upstream or downstream).
/// </summary>
[DataContract]
public class PacketLossStats
{
	/// <summary>
	/// Total number of packets.
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Number of lost packets.
	/// </summary>
	[DataMember(Name = "lost")]
	public int Lost { get; set; }

	/// <summary>
	/// Percentage of lost packets.
	/// </summary>
	[DataMember(Name = "lossPercentage")]
	public double LossPercentage { get; set; }
}

/// <summary>
/// Represents network information.
/// </summary>
[DataContract]
public class NetworkInfo
{
	/// <summary>
	/// The network ID.
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The network name.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}

/// <summary>
/// Represents device information.
/// </summary>
[DataContract]
public class DeviceInfo
{
	/// <summary>
	/// The device name.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The device serial number.
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The device MAC address.
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;
}