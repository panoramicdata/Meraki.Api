namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LiveToolsThroughputTestCallbackPayload
{
	/// <summary>
	/// Callback ID
	/// </summary>
	[DataMember(Name = "callbackId")]
	public string? CallbackId { get; set; }

	/// <summary>
	/// SentAt
	/// </summary>
	[DataMember(Name = "sentAt")]
	public string? SentAt { get; set; }

	/// <summary>
	/// Message
	/// </summary>
	[DataMember(Name = "message")]
	public LiveToolsThroughputTestCallbackPayloadMessage? Message { get; set; }

	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public LiveToolsThroughputTestCallbackPayloadNetwork? Network { get; set; }

	/// <summary>
	/// Organization
	/// </summary>
	[DataMember(Name = "organization")]
	public LiveToolsThroughputTestCallbackPayloadOrganization? Organization { get; set; }
}
