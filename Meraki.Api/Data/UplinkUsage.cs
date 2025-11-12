namespace Meraki.Api.Data;

/// <summary>
/// Uplink Usage
/// </summary>
[DataContract]
public class UplinkUsage
{
	/// <summary>
	/// Gets the uplink
	/// </summary>
	[DataMember(Name = "interface")]
	public Uplink Uplink { get; set; }

	/// <summary>
	/// Gets the sent bytes
	/// </summary>
	[DataMember(Name = "sent")]
	public long SentBytes { get; set; }

	/// <summary>
	/// Gets the received bytes
	/// </summary>
	[DataMember(Name = "received")]
	public long ReceivedBytes { get; set; }
}
