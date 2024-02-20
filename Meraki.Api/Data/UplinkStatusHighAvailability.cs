namespace Meraki.Api.Data;

/// <summary>
/// Uplink status high availability
/// </summary>
[DataContract]
public class UplinkStatusHighAvailability
{
	/// <summary>
	/// The HA role of the device on the network. For devices that do not support HA, this will be 'primary'
	/// </summary>
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;

	/// <summary>
	/// Indicates whether High Availability is enabled for the device. For devices that do not support HA, this will be 'false'
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }


}
