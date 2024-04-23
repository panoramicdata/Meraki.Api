namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Organzation
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LiveToolsThroughputTestCallbackPayloadOrganization
{
	/// <summary>
	/// id
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
