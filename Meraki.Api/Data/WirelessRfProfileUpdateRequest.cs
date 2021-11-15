namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkWirelessRfProfile
/// </summary>
[DataContract]
public class WirelessRfProfileUpdateRequest
{
	/// <summary>
	/// The name of the new profile. Must be unique.
	/// </summary>
	/// <value>The name of the new profile. Must be unique.</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Steers client to best available access point. Can be either true or false.
	/// </summary>
	/// <value>Steers client to best available access point. Can be either true or false.</value>
	[DataMember(Name = "clientBalancingEnabled")]
	public bool? ClientBalancingEnabled { get; set; }

	/// <summary>
	/// Gets or Sets MinBitrateType
	/// </summary>
	[DataMember(Name = "minBitrateType")]
	public MinBitrateType MinBitrateType { get; set; }

	/// <summary>
	/// Gets or Sets BandSelectionType
	/// </summary>
	[DataMember(Name = "bandSelectionType")]
	public BandSelectionType BandSelectionType { get; set; }

	/// <summary>
	/// Gets or Sets ApBandSettings
	/// </summary>
	[DataMember(Name = "apBandSettings")]
	public ApBandSettings ApBandSettings { get; set; } = null!;

	/// <summary>
	/// Gets or Sets TwoFourGhzSettings
	/// </summary>
	[DataMember(Name = "twoFourGhzSettings")]
	public TwoPointFourGhzSettings TwoPointFourGhzSettings { get; set; } = null!;

	/// <summary>
	/// Gets or Sets FiveGhzSettings
	/// </summary>
	[DataMember(Name = "fiveGhzSettings")]
	public FiveGhzSettings FiveGhzSettings { get; set; } = null!;
}
