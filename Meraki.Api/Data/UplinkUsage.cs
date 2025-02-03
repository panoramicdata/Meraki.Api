namespace Meraki.Api.Data;

[DataContract]
public class UplinkUsage
{
	[DataMember(Name = "interface")]
	public Uplink Uplink { get; set; }

	[DataMember(Name = "sent")]
	public long SentBytes { get; set; }

	[DataMember(Name = "received")]
	public long ReceivedBytes { get; set; }
}