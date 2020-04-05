using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule11
	/// </summary>
	[DataContract]
	public partial class SsidTrafficShapingRule
	{
		/// <summary>
		/// A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.
		/// </summary>
		/// <value>A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.</value>
		[DataMember(Name = "definitions", EmitDefaultValue = false)]
		public List<Definition> Definitions { get; set; } = null!;

		/// <summary>
		/// Gets or Sets PerClientBandwidthLimits
		/// </summary>
		[DataMember(Name = "perClientBandwidthLimits", EmitDefaultValue = false)]
		public PerClientBandwidthLimits PerClientBandwidthLimits { get; set; } = null!;

		/// <summary>
		/// The DSCP tag applied by your rule. null means &#39;Do not change DSCP tag&#39;.     For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.
		/// </summary>
		/// <value>The DSCP tag applied by your rule. null means &#39;Do not change DSCP tag&#39;.     For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.</value>
		[DataMember(Name = "dscpTagValue", EmitDefaultValue = false)]
		public int? DscpTagValue { get; set; }

		/// <summary>
		/// The PCP tag applied by your rule. Can be 0 (lowest priority) through 7 (highest priority).     null means &#39;Do not set PCP tag&#39;.
		/// </summary>
		/// <value>The PCP tag applied by your rule. Can be 0 (lowest priority) through 7 (highest priority).     null means &#39;Do not set PCP tag&#39;.</value>
		[DataMember(Name = "pcpTagValue", EmitDefaultValue = false)]
		public int? PcpTagValue { get; set; }
	}
}
