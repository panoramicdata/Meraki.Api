namespace Meraki.Api.Data;

/// <summary>
/// DevicesWirelessRadioAfcPowerLimitsResponse
/// </summary>
[DataContract]
public class DevicesWirelessRadioAfcPowerLimitsResponse
{
	/// <summary>
	/// Name of device
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Network of device
	/// </summary>
	[DataMember(Name = "network")]
	public DevicesWirelessRadioAfcPositionNetwork? Network { get; set; }

	/// <summary>
	/// Serial of device
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Expiration date of power limits table.
	/// </summary>
	[DataMember(Name = "expiresAt")]
	public DateTime? ExpiresAt { get; set; }

	/// <summary>
	/// Time of last AFC fetch
	/// </summary>
	[DataMember(Name = "lastUpdatedAt")]
	public DateTime? LastUpdatedAt { get; set; }

	/// <summary>
	/// Time of last AFC successful fetch
	/// </summary>
	[DataMember(Name = "lastSuccessAt")]
	public DateTime? LastSuccessAt { get; set; }

	/// <summary>
	/// Power limits of each 6 GHz channel
	/// </summary>
	[DataMember(Name = "byChannel")]
	public List<DevicesWirelessRadioAfcPowerLimitsBychannel>? ByChannel { get; set; }

	/// <summary>
	/// Status of AFC response
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; } = string.Empty;

	/// <summary>
	/// Location attributes of device's AFC information
	/// </summary>
	[DataMember(Name = "location")]
	public DevicesWirelessRadioAfcLocation? Location { get; set; }
}
