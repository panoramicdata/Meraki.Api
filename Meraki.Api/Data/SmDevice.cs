namespace Meraki.Api.Data;

/// <summary>
/// SM Devices
/// </summary>
[DataContract]
public class SmDevice : NamedIdentifiedItem
{
	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// SSID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssid")]
	public string Ssid { get; set; } = string.Empty;

	/// <summary>
	/// Wifi mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wifiMac")]
	public string WifiMac { get; set; } = string.Empty;

	/// <summary>
	/// OS Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "osName")]
	public string OsName { get; set; } = string.Empty;

	/// <summary>
	/// System model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "systemModel")]
	public string SystemModel { get; set; } = string.Empty;

	/// <summary>
	/// UUID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uuid")]
	public string Uuid { get; set; } = string.Empty;

	/// <summary>
	/// Serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serialNumber")]
	public string SerialNumber { get; set; } = string.Empty;

	/// <summary>
	/// hasChromeMdm
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hasChromeMdm")]
	public bool HasChromeMdm { get; set; }

	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Ip
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Notes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// Gets the battery est charge
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "batteryEstCharge")]
	public string BatteryEstCharge { get; set; } = string.Empty;
}
