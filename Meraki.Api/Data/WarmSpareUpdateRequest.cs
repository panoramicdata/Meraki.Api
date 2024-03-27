namespace Meraki.Api.Data;

/// <summary>
/// Warm spare
/// </summary>
[DataContract]
public class WarmSpareUpdateRequest
{
	/// <summary>
	/// Enable warm spare
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Serial number of the warm spare appliance
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "spareSerial")]
	public string SpareSerial { get; set; } = string.Empty;

	/// <summary>
	/// Uplink mode, either virtual or public
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uplinkMode")]
	public string UplinkMode { get; set; } = string.Empty;

	/// <summary>
	/// The WAN 1 shared IP
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "virtualIp1")]
	public string? VirtualIp1 { get; set; }

	/// <summary>
	/// The WAN 2 shared IP
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "virtualIp2")]
	public string? VirtualIp2 { get; set; }
}
