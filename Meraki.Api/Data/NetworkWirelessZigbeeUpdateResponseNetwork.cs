namespace Meraki.Api.Data;

/// <summary>
/// Network details
/// </summary>
[DataContract]
public class NetworkWirelessZigbeeUpdateResponseNetwork
{
	/// <summary>
	/// Unique Meraki Identifier for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}