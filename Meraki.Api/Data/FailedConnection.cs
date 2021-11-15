using System;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

[DataContract]
public class FailedConnection
{
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }

	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	[DataMember(Name = "clientMac")]
	public string ClientMac { get; set; } = string.Empty;

	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	[DataMember(Name = "failureStep")]
	public string FailureStep { get; set; } = string.Empty;

	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	[DataMember(Name = "ts")]
	public DateTime Ts { get; set; }
}
