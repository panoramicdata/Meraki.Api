namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Arp Table Request
/// </summary>
[DataContract]

public class LiveToolsArpTableResultRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}
