namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfiles
/// </summary>
[DataContract]
public class NetworkApplianceRfProfile : NamedIdentifiedItem
{
	/// <summary>
	/// ID of network this RF Profile belongs in.
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Settings related to 5Ghz band.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fiveGhzSettings")]
	public NetworkApplianceRfProfileFiveGhzSettings? FiveGhzSettings { get; set; }

	/// <summary>
	/// Per-SSID radio settings by number.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "perSsidSettings")]
	public NetworkApplianceRfProfilePerSsidSettings? PerSsidSettings { get; set; }

	/// <summary>
	/// Settings related to 2.4Ghz band.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "twoFourGhzSettings")]
	public NetworkApplianceRfProfileTwoFourGhzSettings? TwoFourGhzSettings { get; set; }
}
