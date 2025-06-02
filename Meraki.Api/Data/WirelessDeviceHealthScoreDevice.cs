namespace Meraki.Api.Data;

/// <summary>
/// device information
/// </summary>
[DataContract]
public class WirelessDeviceHealthScoreDevice
{
	/// <summary>
	/// device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}