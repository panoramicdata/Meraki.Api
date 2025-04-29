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
	public string? Name { get; set; }

	/// <summary>
	/// Gateway serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }
}