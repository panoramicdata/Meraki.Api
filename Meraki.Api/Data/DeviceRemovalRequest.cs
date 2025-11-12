namespace Meraki.Api.Data;

/// <summary>
/// Device Removal
/// </summary>
[DataContract]
public class DeviceRemovalRequest
{
	/// <summary>
	/// Remove a single device
	/// </summary>
	/// <value>The serial of the device to be removed</value>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}
