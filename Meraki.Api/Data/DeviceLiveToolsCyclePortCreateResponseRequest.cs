namespace Meraki.Api.Data;

/// <summary>
/// Cycle port request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsCyclePortCreateResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// A list of ports to cycle
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<string> Ports { get; set; } = [];
}
