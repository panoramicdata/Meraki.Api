namespace Meraki.Api.Data;

/// <summary>
/// MoveNetworkSmDevices
/// </summary>
[DataContract]
public class MoveNetworkSmDevicesRequest
{
	/// <summary>
	/// The wifiMacs of the devices to be moved.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "wifiMacs")]
	public List<string>? WifiMacs { get; set; }

	/// <summary>
	/// The ids of the devices to be moved.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "ids")]
	public List<string> Ids { get; set; } = new();

	/// <summary>
	/// The serials of the devices to be moved.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be moved.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "scope")]
	public List<object>? Scope { get; set; }

	/// <summary>
	/// The new network to which the devices will be moved.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "newNetwork")]
	public string NewNetwork { get; set; } = string.Empty;
}
