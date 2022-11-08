namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSimsSimUpdateRequest
{
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
