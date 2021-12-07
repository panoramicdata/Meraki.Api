namespace Meraki.Api.Data;

/// <summary>
/// An object describing the bandwidth settings for your rule.
/// </summary>
[DataContract]
public class PerClientBandwidthLimits
{
	/// <summary>
	/// How bandwidth limits are applied by your rule. Can be one of 'network default', 'ignore' or 'custom'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "settings")]
	public string Settings { get; set; } = string.Empty;

	/// <summary>
	/// The bandwidth limits object, specifying the upload ('limitUp') and download ('limitDown') speed in Kbps. These are only enforced if 'settings' is set to 'custom'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bandwidthLimits")]
	public BandwidthLimit BandwidthLimits { get; set; } = new();
}
