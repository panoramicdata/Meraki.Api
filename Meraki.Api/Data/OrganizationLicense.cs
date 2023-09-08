namespace Meraki.Api.Data;

/// <summary>
/// An organization license
/// </summary>
[DataContract]
public class OrganizationLicense : IdentifiedItem
{
	/// <summary>
	/// LicenseType
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "licenseType")]
	public string LicenseType { get; set; } = string.Empty;

	/// <summary>
	/// LicenseKey
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "licenseKey")]
	public string LicenseKey { get; set; } = string.Empty;

	/// <summary>
	/// OrderNumber
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "orderNumber")]
	public string OrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// DeviceSerial
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[ApiForeignKey(typeof(Device))]
	[DataMember(Name = "deviceSerial")]
	public string DeviceSerial { get; set; } = string.Empty;

	/// <summary>
	/// NetworkId
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// State
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "state")]
	public string State { get; set; } = string.Empty;

	/// <summary>
	/// SeatCount
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "seatCount")]
	public int? SeatCount { get; set; }

	/// <summary>
	/// TotalDurationInDays
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "totalDurationInDays")]
	public int TotalDurationInDays { get; set; }

	/// <summary>
	/// DurationInDays
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "durationInDays")]
	public int DurationInDays { get; set; }

	/// <summary>
	/// PermanentlyQueuedLicenses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "permanentlyQueuedLicenses")]
	public List<Dictionary<string, string>> PermanentlyQueuedLicenses { get; set; } = new List<Dictionary<string, string>>();

	/// <summary>
	/// ClaimDate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "claimDate")]
	public string ClaimDate { get; set; } = string.Empty;

	/// <summary>
	/// ActivationDate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "activationDate")]
	public string ActivationDate { get; set; } = string.Empty;

	/// <summary>
	/// ExpirationDate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expirationDate")]
	public string ExpirationDate { get; set; } = string.Empty;

	/// <summary>
	/// headLicenseId - undocumented
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "headLicenseId")]
	public object? HeadLicenseId { get; set; }
}
