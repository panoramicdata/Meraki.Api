namespace Meraki.Api.Data;

/// <summary>
/// A detail items for a device
/// </summary>
[DataContract]
public class DeviceDetail
{
	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "value")]
	public string? Value { get; set; }
}
