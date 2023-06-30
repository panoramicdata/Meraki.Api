namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfiles
/// </summary>
[DataContract]
public class NetworkApplianceRfProfileTwoFourGhzSettings
{
	/// <summary>
	/// Min bitrate (Mbps) of 2.4Ghz band.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrate")]
	public int? MinBitrate { get; set; }

	/// <summary>
	/// Whether ax radio on 2.4Ghz band is on or off.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "axEnabled")]
	public bool? AxEnabled { get; set; }
}
