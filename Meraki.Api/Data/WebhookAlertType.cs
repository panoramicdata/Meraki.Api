namespace Meraki.Api.Data;

/// <summary>
/// Alert type
/// </summary>
[DataContract]
public class WebhookAlertType
{
	/// <summary>
	/// Alert type id
	/// </summary>
	[DataMember(Name = "alertTypeId")]
	public string AlertTypeId { get; set; } = string.Empty;

	/// <summary>
	/// Alert type
	/// </summary>
	[DataMember(Name = "alertType")]
	public string AlertType { get; set; } = string.Empty;

	/// <summary>
	/// Version
	/// </summary>
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Shared secret
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	public string SharedSecret { get; set; } = string.Empty;

	/// <summary>
	/// Sent at
	/// </summary>
	[DataMember(Name = "sentAt")]
	public string SentAt { get; set; } = string.Empty;

	/// <summary>
	/// Alert id
	/// </summary>
	[DataMember(Name = "alertId")]
	public string AlertId { get; set; } = string.Empty;

	/// <summary>
	/// Alert level
	/// </summary>
	[DataMember(Name = "alertLevel")]
	public string AlertLevel { get; set; } = string.Empty;

	/// <summary>
	/// Occurred at
	/// </summary>
	[DataMember(Name = "occurredAt")]
	public string OccurredAt { get; set; } = string.Empty;

	/// <summary>
	/// Alert data
	/// </summary>
	[DataMember(Name = "alertData")]
	public List<string> AlertData { get; set; } = new();

	/// <summary>
	/// Organization id
	/// </summary>
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// Organization name
	/// </summary>
	[DataMember(Name = "organizationName")]
	public string OrganizationName { get; set; } = string.Empty;

	/// <summary>
	/// Organization url
	/// </summary>
	[DataMember(Name = "organizationUrl")]
	public string OrganizationUrl { get; set; } = string.Empty;

	/// <summary>
	/// Device serial
	/// </summary>
	[DataMember(Name = "deviceSerial")]
	public string DeviceSerial { get; set; } = string.Empty;

	/// <summary>
	/// Device mac
	/// </summary>
	[DataMember(Name = "deviceMac")]
	public string DeviceMac { get; set; } = string.Empty;

	/// <summary>
	/// Device name
	/// </summary>
	[DataMember(Name = "deviceName")]
	public string DeviceName { get; set; } = string.Empty;

	/// <summary>
	/// Device url
	/// </summary>
	[DataMember(Name = "deviceUrl")]
	public string DeviceUrl { get; set; } = string.Empty;

	/// <summary>
	/// Device tags
	/// </summary>
	[DataMember(Name = "deviceTags")]
	public List<string> DeviceTags { get; set; } = new();

	/// <summary>
	/// Device model
	/// </summary>
	[DataMember(Name = "deviceModel")]
	public string DeviceModel { get; set; } = string.Empty;

	/// <summary>
	/// Network id
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[DataMember(Name = "networkName")]
	public string NetworkName { get; set; } = string.Empty;

	/// <summary>
	/// Network URL
	/// </summary>
	[DataMember(Name = "networkUrl")]
	public string NetworkUrl { get; set; } = string.Empty;
}
