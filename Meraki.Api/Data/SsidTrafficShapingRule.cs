namespace Meraki.Api.Data;

/// <summary>
/// Rule11
/// </summary>
[DataContract]
public class SsidTrafficShapingRule
{
	/// <summary>
	/// A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "definitions")]
	public List<Definition> Definitions { get; set; } = null!;

	/// <summary>
	/// An object describing the bandwidth settings for your rule.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "perClientBandwidthLimits")]
	public PerClientBandwidthLimits PerClientBandwidthLimits { get; set; } = null!;

	/// <summary>
	/// The DSCP tag applied by your rule. null means 'Do not change DSCP tag'. For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dscpTagValue")]
	public int? DscpTagValue { get; set; }

	/// <summary>
	/// The PCP tag applied by your rule. Can be 0 (lowest priority) through 7 (highest priority). null means 'Do not set PCP tag'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "pcpTagValue")]
	public int? PcpTagValue { get; set; }
}
