namespace Meraki.Api.Data;

/// <summary>
/// Application usage
/// </summary>
[DataContract]
public class SubclassApplicationUsage
{
	/// <summary>
	/// Application
	/// </summary>
	[DataMember(Name = "application")]
	public string Application { get; set; } = string.Empty;

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
	/// Total bytes received by the client for the application, as the current API names it
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "received")]
	public long? Received { get; set; }
}
