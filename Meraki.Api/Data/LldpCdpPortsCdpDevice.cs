namespace Meraki.Api.Data;

/// <summary>
/// LldpCdp Ports Device
/// </summary>
[DataContract]
public class LldpCdpPortsDevice
{
	/// <summary>
	/// Dashboard Url for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }

}
