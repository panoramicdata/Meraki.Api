namespace Meraki.Api.Data;

/// <summary>
/// The new fields of the device. Each field of this object is optional.
/// </summary>
[DataContract]
public class DeviceFields
{
	/// <summary>
	/// New name for the device
	/// </summary>
	/// <value>New name for the device</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
	/// <summary>
	/// New notes for the device
	/// </summary>
	/// <value>New notes for the device</value>
	[DataMember(Name = "notes")]
	public string Notes { get; set; } = string.Empty;
}
