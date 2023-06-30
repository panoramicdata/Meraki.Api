namespace Meraki.Api.Data;

/// <summary>
/// Usage history
/// </summary>
[DataContract]
public class ClientUsageHistory
{
	/// <summary>
	/// Sent
	/// </summary>
	[DataMember(Name = "sent")]
	public long Sent { get; set; }

	/// <summary>
	/// Received
	/// </summary>
	[DataMember(Name = "received")]
	public long Received { get; set; }

	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;
}
