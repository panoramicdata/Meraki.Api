namespace Meraki.Api.Data;

/// <summary>
/// TrafficShapingRule
/// </summary>
[DataContract]
public class TrafficShapingRule
{
	/// <summary>
	/// A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "definitions")]
	public List<Definition> Definitions { get; set; } = new();

	/// <summary>
	/// Gets or Sets PerClientBandwidthLimits
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "perClientBandwidthLimits")]
	public PerClientBandwidthLimits PerClientBandwidthLimits { get; set; } = new();

	/// <summary>
	/// The DSCP tag applied by your rule. null means 'Do not change DSCP tag'. For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "dscpTagValue")]
	public int? DscpTagValue { get; set; }

	/// <summary>
	/// The PCP tag applied by your rule. Can be 0 (lowest priority) through 7 (highest priority). null means 'Do not set PCP tag'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "pcpTagValue")]
	public int? PcpTagValue { get; set; }

	/// <summary>
	/// A string, indicating the priority level for packets bound to your rule. Can be 'low', 'normal' or 'high'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "priority")]
	public Priority Priority { get; set; }
}
