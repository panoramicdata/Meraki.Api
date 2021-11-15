using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Checkin network sm devices
/// </summary>
[DataContract]
public class CheckinNetworkSmDevices
{
	/// <summary>
	/// Ids
	/// </summary>
	[DataMember(Name = "ids")]
	public List<string> Ids { get; set; } = new();

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope")]
	public List<string>? Scope { get; set; }

	/// <summary>
	/// Serials
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// Wifi macs
	/// </summary>
	[DataMember(Name = "wifiMacs")]
	public List<string>? WifiMacs { get; set; }

	/// <summary>
	/// Pin
	/// </summary>
	[DataMember(Name = "pin")]
	public List<string>? Pin { get; set; }
}
