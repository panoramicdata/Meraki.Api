namespace Meraki.Api.Data;

/// <summary>
/// Usage history
/// </summary>
[DataContract]
public class SubclassUsageHistory
{
	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Recv
	/// </summary>
	[DataMember(Name = "recv")]
	public int Recv { get; set; }

	/// <summary>
	/// Sent
	/// </summary>
	[DataMember(Name = "sent")]
	public int Sent { get; set; }

	/// <summary>
	/// Usage received by the client on a given day, as the current API names it
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "received")]
	public double? Received { get; set; }
}
