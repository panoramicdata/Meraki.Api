namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Organzation
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCallbackOrganization
{
	/// <summary>
	/// id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
