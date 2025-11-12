namespace Meraki.Api.Data;

/// <summary>
/// Failed Connection
/// </summary>
[DataContract]
public class FailedConnection
{
	/// <summary>
	/// Gets the ssid number
	/// </summary>
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }

	/// <summary>
	/// Gets the vlan
	/// </summary>
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// Gets the client mac
	/// </summary>
	[DataMember(Name = "clientMac")]
	public string ClientMac { get; set; } = string.Empty;

	/// <summary>
	/// Gets the serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Gets the failure step
	/// </summary>
	[DataMember(Name = "failureStep")]
	public string FailureStep { get; set; } = string.Empty;

	/// <summary>
	/// Gets the type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Gets the ts
	/// </summary>
	[DataMember(Name = "ts")]
	public DateTime Ts { get; set; }
}
