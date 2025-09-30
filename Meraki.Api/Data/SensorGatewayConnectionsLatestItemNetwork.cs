namespace Meraki.Api.Data;
/// <summary>
/// Sensor Gateway Connections Latest Item Network
/// </summary>
[DataContract]

public class SensorGatewayConnectionsLatestItemNetwork
{
	/// <summary>
	/// The id of the network.
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Read)]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the network.
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Read)]
	public string Name { get; set; } = string.Empty;
}