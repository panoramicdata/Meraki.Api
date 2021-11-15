using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Client traffic history
/// </summary>
[DataContract]
public class ClientTrafficHistory
{
	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Application
	/// </summary>
	[DataMember(Name = "application")]
	public string Application { get; set; } = string.Empty;

	/// <summary>
	/// Destination
	/// </summary>
	[DataMember(Name = "destination")]
	public string Destination { get; set; } = string.Empty;

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
	/// Num flows
	/// </summary>
	[DataMember(Name = "numFlows")]
	public int NumFlows { get; set; }

	/// <summary>
	/// Active seconds
	/// </summary>
	[DataMember(Name = "activeSeconds")]
	public int ActiveSeconds { get; set; }
}
