namespace Meraki.Api.Data;

/// <summary>
/// Network traffic
/// </summary>
[DataContract]
public class NetworkTraffic
{
	/// <summary>
	/// Application
	/// </summary>
	[DataMember(Name = "application")]
	public string Application { get; set; } = string.Empty;

	/// <summary>
	/// Destination
	/// </summary>
	[DataMember(Name = "destination")]
	public string? Destination { get; set; }

	/// <summary>
	/// Protocol
	/// </summary>
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// Port
	/// </summary>
	[DataMember(Name = "port")]
	public int Port { get; set; }

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
	/// Number of clients
	/// </summary>
	[DataMember(Name = "numClients")]
	public int NumClients { get; set; }

	/// <summary>
	/// Active time
	/// </summary>
	[DataMember(Name = "activeTime")]
	public int ActiveTime { get; set; }

	/// <summary>
	/// Flows
	/// </summary>
	[DataMember(Name = "flows")]
	public int Flows { get; set; }
}
