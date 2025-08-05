namespace Meraki.Api.Data;

/// <summary>
/// Routing table request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsRoutingTableCreateResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}