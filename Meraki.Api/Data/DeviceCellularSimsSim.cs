namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSimsSim
{
	/// <summary>
	/// Integrated Circuit Card Identification Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "iccid")]
	public string? Iccid { get; set; }

	/// <summary>
	/// International Mobile Subscriber Identity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imsi")]
	public string? Imsi { get; set; }

	/// <summary>
	/// Mobile Station Integrated Services Digital NetworkInternational Mobile Subscriber Identity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "msisdn")]
	public string? Msisdn { get; set; }

	/// <summary>
	/// SIM slot being configured. Must be 'sim1' on single-sim devices. Use 'sim3' for eSIM.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "slot")]
	public string? Slot { get; set; }

	/// <summary>Status of the SIM card.
	/// enum = ["PIN required", "PUK required", "active", "inserted", "not inserted", ...] SIM slot being configured.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// Priority of SIM slot being configured. Use a value between 1 and total number of SIMs available. The value must be unique for each SIM.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "simOrder")]
	public int? SimOrder { get; set; }

	/// <summary>
	/// Is Primary
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isPrimary")]
	public bool? IsPrimary { get; set; }

	/// <summary>
	/// A list of Sims
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "apns")]
	public List<DeviceCellularSimsSimApn>? Apns { get; set; }
}
