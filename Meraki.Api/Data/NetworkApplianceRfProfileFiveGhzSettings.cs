namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfiles
/// </summary>
[DataContract]
public class NetworkApplianceRfProfileFiveGhzSettings
{
	/// <summary>
	/// Min bitrate (Mbps) of 5Ghz band.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrate")]
	public double? MinBitrate { get; set; }

	/// <summary>
	/// Whether ax radio on 5Ghz band is on or off.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "axEnabled")]
	public bool? AxEnabled { get; set; }
}
