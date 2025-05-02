namespace Meraki.Api.Data;

/// <summary>
/// Network
/// </summary>
[DataContract]
public class DevicesWirelessZigbeeNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Read)]
	public string? Id { get; set; }

	/// <summary>
	/// Network Name
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Read)]
	public string? Name { get; set; }
}