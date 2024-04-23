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
	public LiveToolsThroughputTestCallbackMessage? Message { get; set; }

	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public LiveToolsThroughputTestCallbackNetwork? Network { get; set; }

	/// <summary>
	/// Organization
	/// </summary>
	[DataMember(Name = "organization")]
	public LiveToolsThroughputTestCallbackOrganization? Organization { get; set; }
}
