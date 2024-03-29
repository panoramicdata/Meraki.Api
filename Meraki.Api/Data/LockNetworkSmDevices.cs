namespace Meraki.Api.Data;

/// <summary>
/// LockNetworkSmDevices
/// </summary>
[DataContract]
public class LockNetworkSmDevices
{
	/// <summary>
	/// The wifiMacs of the devices to be locked.
	/// </summary>
	/// <value>The wifiMacs of the devices to be locked.</value>
	[DataMember(Name = "wifiMacs")]
	public string WifiMacs { get; set; } = string.Empty;
	/// <summary>
	/// The ids of the devices to be locked.
	/// </summary>
	/// <value>The ids of the devices to be locked.</value>
	[DataMember(Name = "ids")]
	public string Ids { get; set; } = string.Empty;
	/// <summary>
	/// The serials of the devices to be locked.
	/// </summary>
	/// <value>The serials of the devices to be locked.</value>
	[DataMember(Name = "serials")]
	public string Serials { get; set; } = string.Empty;
	/// <summary>
	/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be wiped.
	/// </summary>
	/// <value>The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be wiped.</value>
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;
	/// <summary>
	/// The pin number for locking macOS devices (a six digit number). Required only for macOS devices.
	/// </summary>
	/// <value>The pin number for locking macOS devices (a six digit number). Required only for macOS devices.</value>
	[DataMember(Name = "pin")]
	public int? Pin { get; set; }
}
