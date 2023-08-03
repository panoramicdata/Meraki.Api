namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfiles
/// </summary>
[DataContract]
public class NetworkApplianceRfProfileCreateUpdate
{
	/// <summary>
	/// The name of the new profile. Must be unique. This param is required on creation.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

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
