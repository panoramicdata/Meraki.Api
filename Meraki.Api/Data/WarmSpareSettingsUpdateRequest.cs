namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkWarmSpareSettings
/// </summary>
[DataContract]
public class WarmSpareSettingsUpdateRequest
{
	/// <summary>
	/// Enable warm spare
	/// </summary>
	/// <value>Enable warm spare</value>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Serial number of the warm spare appliance
	/// </summary>
	/// <value>Serial number of the warm spare appliance</value>
	[DataMember(Name = "spareSerial")]
	public string SpareSerial { get; set; } = null!;

	/// <summary>
	/// Uplink mode, either virtual or public
	/// </summary>
	/// <value>Uplink mode, either virtual or public</value>
	[DataMember(Name = "uplinkMode")]
	public string UplinkMode { get; set; } = null!;

	/// <summary>
	/// The WAN 1 shared IP
	/// </summary>
	/// <value>The WAN 1 shared IP</value>
	[DataMember(Name = "virtualIp1")]
	public string VirtualIp1 { get; set; } = null!;

	/// <summary>
	/// The WAN 2 shared IP
	/// </summary>
	/// <value>The WAN 2 shared IP</value>
	[DataMember(Name = "virtualIp2")]
	public string VirtualIp2 { get; set; } = null!;
}
