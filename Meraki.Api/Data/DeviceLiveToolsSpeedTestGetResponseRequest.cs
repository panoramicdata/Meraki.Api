namespace Meraki.Api.Data;

/// <summary>
/// Request details.
/// </summary>
[DataContract]
public class DeviceLiveToolsSpeedTestGetResponseRequest
{
	/// <summary>
	/// WAN interface.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Serial number.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}