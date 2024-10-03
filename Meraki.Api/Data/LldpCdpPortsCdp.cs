namespace Meraki.Api.Data;

/// <summary>
/// LldpCdp Ports Cdp
/// </summary>
[DataContract]
public class LldpCdpPortsCdp
{
	/// <summary>
	/// Management IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	///ID for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceId")]
	public string? DeviceId { get; set; }

	/// <summary>
	/// Model for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// Name for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// ID for the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portId")]
	public string? PortId { get; set; }

	/// <summary>
	/// Source port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sourcePort")]
	public string? SourcePort { get; set; }

	/// <summary>
	/// Version for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public string? Version { get; set; }
}
