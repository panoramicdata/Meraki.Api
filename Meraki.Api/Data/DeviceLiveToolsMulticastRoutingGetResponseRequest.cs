namespace Meraki.Api.Data;

/// <summary>
/// Multicast routing request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsMulticastRoutingGetResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}