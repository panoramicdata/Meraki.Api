namespace Meraki.Api.Data;

/// <summary>
/// DevicesWirelessRadioAfcPowerLimitsResponse
/// </summary>
public class DevicesWirelessRadioAfcPowerLimitsResponse
{
	/// <summary>
	/// Name of device
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Network of device
	/// </summary>
	public DevicesWirelessRadioAfcPositionNetwork? Network { get; set; }

	/// <summary>
	/// Serial of device
	/// </summary>
	public string? Serial { get; set; }

	/// <summary>
	/// Expiration date of power limits table.
	/// </summary>
	public DateTime? ExpiresAt { get; set; }

	/// <summary>
	/// Time of last AFC fetch
	/// </summary>
	public DateTime? LastUpdatedAt { get; set; }

	/// <summary>
	/// Time of last AFC successful fetch
	/// </summary>
	public DateTime? LastSuccessAt { get; set; }

	/// <summary>
	/// Power limits of each 6 GHz channel
	/// </summary>
	public List<DevicesWirelessRadioAfcPowerLimitsBychannel>? ByChannel { get; set; }

	/// <summary>
	/// Status of AFC response
	/// </summary>
	public string? Status { get; set; } = string.Empty;

	/// <summary>
	/// Location attributes of device's AFC information
	/// </summary>
	public DevicesWirelessRadioAfcLocation? Location { get; set; }
}
