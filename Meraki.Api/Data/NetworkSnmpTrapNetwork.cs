namespace Meraki.Api.Data;

/// <summary>
/// Configuration details for the network
/// </summary>
[DataContract]
public class NetworkSnmpTrapNetwork
{
	/// <summary>
	/// ID of the network
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the network
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}