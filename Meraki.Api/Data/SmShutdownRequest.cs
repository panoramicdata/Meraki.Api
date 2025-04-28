namespace Meraki.Api.Data;

/// <summary>
/// SmShutdownRequest
/// </summary>
public class SmShutdownRequest
{
	/// <summary>
	/// The ids of the endpoints to be shutdown.
	/// </summary>
	[DataMember(Name = "ids")]
	public List<string>? Ids { get; set; }

	/// <summary>
	/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the endpoints to be shutdown.
	/// </summary>
	[DataMember(Name = "scope")]
	public List<string>? Scope { get; set; }

	/// <summary>
	/// The serials of the endpoints to be shutdown.
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// The wifiMacs of the endpoints to be shutdown.
	/// </summary>
	[DataMember(Name = "wifiMacs")]
	public List<string>? WifiMacs { get; set; }
}
