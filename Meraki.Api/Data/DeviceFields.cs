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
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
	/// <summary>
	/// New notes for the device
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }
}
