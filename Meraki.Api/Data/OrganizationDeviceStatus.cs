namespace Meraki.Api.Data;

/// <summary>
/// An organization device status
/// </summary>
[DataContract]
public class OrganizationDeviceStatus : NamedItem
{
	/// <summary>
	/// serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// publicIp
	/// </summary>
	[DataMember(Name = "publicIp")]
	public string? PublicIp { get; set; }

	/// <summary>
	/// networkId
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// lastReportedAt
	/// </summary>
	[DataMember(Name = "lastReportedAt")]
	public DateTime? LastReportedAt { get; set; }

	/// <summary>
	/// lanIp
	/// </summary>
	[DataMember(Name = "lanIp")]
	public string? LanIp { get; set; }

	/// <summary>
	/// Gateway
	/// </summary>
	[DataMember(Name = "gateway")]
	public string? GatewayIp { get; set; }

	/// <summary>
	/// IP Type (dhcp)
	/// </summary>
	[DataMember(Name = "ipType")]
	public string? IpType { get; set; }

	/// <summary>
	/// Primary DNS IP address
	/// </summary>
	[DataMember(Name = "primaryDns")]
	public string? PrimaryDnsIp { get; set; }

	/// <summary>
	/// Secondary DNS IP address
	/// </summary>
	[DataMember(Name = "secondaryDns")]
	public string? SecondaryDnsIp { get; set; }

	/// <summary>
	/// usingCellularFailover
	/// </summary>
	[DataMember(Name = "usingCellularFailover")]
	public bool? UsingCellularFailover { get; set; }

	/// <summary>
	/// wan1Ip
	/// </summary>
	[DataMember(Name = "wan1Ip")]
	public string? Wan1Ip { get; set; }

	/// <summary>
	/// wan2Ip
	/// </summary>
	[DataMember(Name = "wan2Ip")]
	public string? Wan2Ip { get; set; }

	/// <summary>
	/// The Device ProductType
	/// </summary>
	[DataMember(Name = "productType")]
	public ProductType? productType { get; set; }

	/// <summary>
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// Tags
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// ConfigurationUpdatedAt
	/// </summary>
	[DataMember(Name = "configurationUpdatedAt")]
	public DateTime? ConfigurationUpdatedAt { get; set; }
}
