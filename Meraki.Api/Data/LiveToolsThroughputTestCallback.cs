namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCallback
{
	/// <summary>
	/// Callbackl ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "callbackId")]
	public string? CallbackId { get; set; }

	/// <summary>
	/// SentAt
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sentAt")]
	public string? SentAt { get; set; }

	/// <summary>
	/// Message
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "message")]
	public LiveToolsThroughputTestCallbackMessage? Messsage { get; set; }

	/// <summary>
	/// Network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public LiveToolsThroughputTestCallbackNetwork? Network { get; set; }

	/// <summary>
	/// Organization
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "organization")]
	public LiveToolsThroughputTestCallbackOrganization? Organization { get; set; }
}
