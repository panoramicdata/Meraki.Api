using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// A device uplink
/// </summary>
[DataContract]
public class DeviceUplink
{
	/// <summary>
	/// interface
	/// </summary>
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// ip
	/// </summary>
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// gateway
	/// </summary>
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// publicIp
	/// </summary>
	[DataMember(Name = "publicIp")]
	public string PublicIp { get; set; } = string.Empty;

	/// <summary>
	/// dns
	/// </summary>
	[DataMember(Name = "dns")]
	public string Dns { get; set; } = string.Empty;

	/// <summary>
	/// vlan
	/// </summary>
	[DataMember(Name = "vlan")]
	public string Vlan { get; set; } = string.Empty;

	/// <summary>
	/// usingStaticIp
	/// </summary>
	[DataMember(Name = "usingStaticIp")]
	public bool? UsingStaticIp { get; set; }
}
