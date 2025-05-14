namespace Meraki.Api.Data;

/// <summary>
/// Gateway
/// </summary>
[DataContract]
public class DevicesWirelessZigbeeGateway
{
	/// <summary>
	/// MR Device Name
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }

	/// <summary>
	/// Gateway serial
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Read)]
	public string? Serial { get; set; }
}