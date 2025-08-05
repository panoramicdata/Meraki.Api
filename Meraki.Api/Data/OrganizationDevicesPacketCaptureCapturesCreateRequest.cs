namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Captures Create Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesCreateRequest
{
	/// <summary>
	/// Duration in seconds of packet capture
	/// </summary>
	[DataMember(Name = "duration")]
	public int? Duration { get; set; }

	/// <summary>
	/// Destination of packet capture file. Possible values: [upload_to_cloud]
	/// </summary>
	[DataMember(Name = "destination")]
	public string? Destination { get; set; }

	/// <summary>
	/// Filter expression for packet capture
	/// </summary>
	[DataMember(Name = "filterExpression")]
	public string? FilterExpression { get; set; }

	/// <summary>
	/// Interface of the device
	/// </summary>
	[DataMember(Name = "interface")]
	public string? Interface { get; set; }

	/// <summary>
	/// Name of packet capture file
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Reason for taking the packet capture
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// Output type of packet capture file. Possible values: text, pcap, cloudshark, or upload_to_cloud
	/// </summary>
	[DataMember(Name = "outputType")]
	public string? OutputType { get; set; }

	/// <summary>
	/// Ports of packet capture file, comma-separated
	/// </summary>
	[DataMember(Name = "ports")]
	public string? Ports { get; set; }

	/// <summary>
	/// The serial(s) of the device(s)
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];
}
