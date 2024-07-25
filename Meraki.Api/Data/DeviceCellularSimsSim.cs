namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSimsSim
{
	/// <summary>
	/// Priority of SIM slot being configured. Use a value between 1 and total number of SIMs available. The value must be unique for each SIM.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "simOrder")]
	public int? SimOrder { get; set; }

	/// <summary>
	/// A list of Sims
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "slot")]
	public string? Slot { get; set; }

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
