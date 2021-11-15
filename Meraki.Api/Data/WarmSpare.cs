using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Warm spare
/// </summary>
[DataContract]
public class WarmSpare
{
	/// <summary>
	/// Enable warm spare
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Primary serial
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "primarySerial")]
	public string PrimarySerial { get; set; } = string.Empty;

	/// <summary>
	/// Serial number of the warm spare appliance
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "spareSerial")]
	public string SpareSerial { get; set; } = string.Empty;

	/// <summary>
	/// Uplink mode, either virtual or public
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "uplinkMode")]
	public string UplinkMode { get; set; } = string.Empty;

	/// <summary>
	/// The WAN 1 shared IP
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "wan1")]
	public VirtualIp Wan1 { get; set; } = new();

	/// <summary>
	/// The WAN 2 shared IP
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "wan2")]
	public VirtualIp Wan2 { get; set; } = new();
}
