namespace Meraki.Api.Data;

/// <summary>
/// Network
/// </summary>
public class DevicesWirelessZigbeeNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Network Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}