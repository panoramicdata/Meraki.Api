namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkWirelessRfProfile
/// </summary>
[DataContract]
public class WirelessRfProfileCreateUpdateRequest
{
	/// <summary>
	/// The name of the new profile. Must be unique.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Steers client to best available access point. Can be either true or false.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "clientBalancingEnabled")]
	public bool? ClientBalancingEnabled { get; set; }

	/// <summary>
	/// Gets or Sets MinBitrateType
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrateType")]
	public MinBitrateType? MinBitrateType { get; set; }

	/// <summary>
	/// Gets or Sets BandSelectionType
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandSelectionType")]
	public BandSelectionType? BandSelectionType { get; set; }

	/// <summary>
	/// Gets or Sets ApBandSettings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "apBandSettings")]
	public ApBandSettings? ApBandSettings { get; set; }

	/// <summary>
	/// Settings related to radio transmission.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "transmission")]
	public WirelessRfProfileTransmission? Transmission { get; set; }

	/// <summary>
	/// Gets or Sets TwoFourGhzSettings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "twoFourGhzSettings")]
	public TwoPointFourGhzSettings? TwoPointFourGhzSettings { get; set; }

	/// <summary>
	/// Gets or Sets FiveGhzSettings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fiveGhzSettings")]
	public FiveGhzSettings? FiveGhzSettings { get; set; }

	/// <summary>
	/// Per-SSID radio settings by number.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "perSsidSettings")]
	public PerSsidSettings? PerSsidSettings { get; set; }
}
