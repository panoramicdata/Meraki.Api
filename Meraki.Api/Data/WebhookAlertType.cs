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
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Shared secret
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "sharedSecret")]
	public string SharedSecret { get; set; } = string.Empty;

	/// <summary>
	/// Sent at
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "sentAt")]
	public DateTime SentAt { get; set; }

	/// <summary>
	/// Alert id
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "alertId")]
	public string AlertId { get; set; } = string.Empty;

	/// <summary>
	/// Alert level
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "alertLevel")]
	public string AlertLevel { get; set; } = string.Empty;

	/// <summary>
	/// Occurred at
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "occurredAt")]
	public DateTime OccurredAt { get; set; }

	/// <summary>
	/// Alert data
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "alertData")]
	public List<string> AlertData { get; set; } = [];

	/// <summary>
	/// Organization id
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// Organization name
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "organizationName")]
	public string OrganizationName { get; set; } = string.Empty;

	/// <summary>
	/// Organization url
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "organizationUrl")]
	public string OrganizationUrl { get; set; } = string.Empty;

	/// <summary>
	/// Device serial
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "deviceSerial")]
	public string DeviceSerial { get; set; } = string.Empty;

	/// <summary>
	/// Device mac
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "deviceMac")]
	public string DeviceMac { get; set; } = string.Empty;

	/// <summary>
	/// Device name
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "deviceName")]
	public string DeviceName { get; set; } = string.Empty;

	/// <summary>
	/// Device url
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "deviceUrl")]
	public string DeviceUrl { get; set; } = string.Empty;

	/// <summary>
	/// Device tags
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "deviceTags")]
	public List<string> DeviceTags { get; set; } = [];

	/// <summary>
	/// Device model
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "deviceModel")]
	public string DeviceModel { get; set; } = string.Empty;

	/// <summary>
	/// Network id
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "networkName")]
	public string NetworkName { get; set; } = string.Empty;

	/// <summary>
	/// Network URL
	/// </summary>
	[Obsolete("Never returned at this level: the Dashboard API sends it inside Example. Use Example instead. This property will be removed in a later release.")]
	[DataMember(Name = "networkUrl")]
	public string NetworkUrl { get; set; } = string.Empty;

	/// <summary>
	/// Example alert payload for this alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "example")]
	public WebhookAlertTypeExample? Example { get; set; }
}
