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
	/// <value>How bandwidth limits are applied by your rule. Can be one of 'network default', 'ignore' or 'custom'.</value>
	[DataMember(Name = "settings")]
	public string Settings { get; set; } = null!;

	/// <summary>
	/// Gets or Sets BandwidthLimits
	/// </summary>
	[DataMember(Name = "bandwidthLimits")]
	public BandwidthLimit BandwidthLimits { get; set; } = null!;
}
