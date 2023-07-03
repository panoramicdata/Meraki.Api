namespace Meraki.Api.Data;

/// <summary>
/// Uplinks
/// </summary>
[DataContract]
public class Uplinks
{
	/// <summary>
	/// Interface
	/// </summary>
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Ip
	/// </summary>
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Provider
	/// </summary>
	[DataMember(Name = "provider")]
	public string? Provider { get; set; }

	/// <summary>
	/// Gateway
	/// </summary>
	[DataMember(Name = "gateway")]
	public string? Gateway { get; set; }

	/// <summary>
	/// Public ip
	/// </summary>
	[DataMember(Name = "publicIp")]
	public string PublicIp { get; set; } = string.Empty;

	/// <summary>
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// Signal stat
	/// </summary>
	[DataMember(Name = "signalStat")]
	[JsonConverter(typeof(EmptyArrayOrDictionaryConverter))]
	public SignalStat? SignalStat { get; set; }

	/// <summary>
	/// Connection type
	/// </summary>
	[DataMember(Name = "connectionType")]
	public string? ConnectionType { get; set; }

	/// <summary>
	/// Apn
	/// </summary>
	[DataMember(Name = "apn")]
	public string? Apn { get; set; }

	/// <summary>
	/// DNS 1
	/// </summary>
	[DataMember(Name = "dns1")]
	public string? Dns1 { get; set; }

	/// <summary>
	/// DNS 2
	/// </summary>
	[DataMember(Name = "dns2")]
	public string? Dns2 { get; set; }

	/// <summary>
	/// Apn
	/// </summary>
	[DataMember(Name = "signalType")]
	public string? SignalType { get; set; }

	/// <summary>
	/// Iccid
	/// </summary>
	[DataMember(Name = "iccid")]
	public string? Iccid { get; set; }

	/// <summary>
	/// Primary DNS
	/// </summary>
	[DataMember(Name = "primaryDns")]
	public string? PrimaryDns { get; set; }

	/// <summary>
	/// Secondary DNS
	/// </summary>
	[DataMember(Name = "secondaryDns")]
	public string? SecondaryDns { get; set; }

	/// <summary>
	/// Ip assigned by
	/// </summary>
	[DataMember(Name = "ipAssignedBy")]
	public string? IpAssignedBy { get; set; }
}
