namespace Meraki.Api.Data;

/// <summary>
/// An example payload for a webhook alert type
/// </summary>
[DataContract]
public class WebhookAlertTypeExample
{
	/// <summary>Webhook payload version</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public string? Version { get; set; }

	/// <summary>Shared secret configured on the HTTP server</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }

	/// <summary>When the webhook was sent</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sentAt")]
	public DateTime? SentAt { get; set; }

	/// <summary>Alert ID</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertId")]
	public string? AlertId { get; set; }

	/// <summary>Alert type name</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertType")]
	public string? AlertType { get; set; }

	/// <summary>Alert type ID</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertTypeId")]
	public string? AlertTypeId { get; set; }

	/// <summary>Alert level</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertLevel")]
	public string? AlertLevel { get; set; }

	/// <summary>When the alert occurred</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "occurredAt")]
	public DateTime? OccurredAt { get; set; }

	/// <summary>Alert-type-specific data; its shape varies by alert type</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertData")]
	public object? AlertData { get; set; }

	/// <summary>Organization ID</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public string? OrganizationId { get; set; }

	/// <summary>Organization name</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationName")]
	public string? OrganizationName { get; set; }

	/// <summary>Organization URL</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationUrl")]
	public string? OrganizationUrl { get; set; }

	/// <summary>Device serial</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceSerial")]
	public string? DeviceSerial { get; set; }

	/// <summary>Device MAC address</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceMac")]
	public string? DeviceMac { get; set; }

	/// <summary>Device name</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceName")]
	public string? DeviceName { get; set; }

	/// <summary>Device URL</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceUrl")]
	public string? DeviceUrl { get; set; }

	/// <summary>Device tags</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceTags")]
	public List<string>? DeviceTags { get; set; }

	/// <summary>Device model</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceModel")]
	public string? DeviceModel { get; set; }

	/// <summary>Network ID</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>Network name</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkName")]
	public string? NetworkName { get; set; }

	/// <summary>Network URL</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkUrl")]
	public string? NetworkUrl { get; set; }

	/// <summary>Network tags</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkTags")]
	public List<string>? NetworkTags { get; set; }

	/// <summary>Network enrollment string</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enrollmentString")]
	public string? EnrollmentString { get; set; }

	/// <summary>Network notes</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>Product types in the network</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<string>? ProductTypes { get; set; }

	/// <summary>Encrypted ID</summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "encryptedId")]
	public string? EncryptedId { get; set; }
}
