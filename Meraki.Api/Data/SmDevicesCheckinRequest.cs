namespace Meraki.Api.Data;

/// <summary>
/// Checkin network sm devices
/// </summary>
[DataContract]
public class SmDevicesCheckinRequest
{
	/// <summary>
	/// The ids of the devices to be checked-in.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "ids")]
	public List<string> Ids { get; set; } = new();

	/// <summary>
	/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be checked-in.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "scope")]
	public List<string>? Scope { get; set; }

	/// <summary>
	/// The serials of the devices to be checked-in.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// The wifiMacs of the devices to be checked-in.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "wifiMacs")]
	public List<string>? WifiMacs { get; set; }
}
