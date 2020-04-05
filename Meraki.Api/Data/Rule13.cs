using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule13
	/// </summary>
	[DataContract]
	public partial class Rule13
	{
		/// <summary>
		/// A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.
		/// </summary>
		/// <value>A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.</value>
		[DataMember(Name = "definitions", EmitDefaultValue = false)]
		public List<Definition> Definitions { get; set; }

		/// <summary>
		/// Gets or Sets PerClientBandwidthLimits
		/// </summary>
		[DataMember(Name = "perClientBandwidthLimits", EmitDefaultValue = false)]
		public PerClientBandwidthLimits PerClientBandwidthLimits { get; set; }

		/// <summary>
		/// The DSCP tag applied by your rule. null means &#39;Do not change DSCP tag&#39;.     For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.
		/// </summary>
		/// <value>The DSCP tag applied by your rule. null means &#39;Do not change DSCP tag&#39;.     For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.</value>
		[DataMember(Name = "dscpTagValue", EmitDefaultValue = false)]
		public int? DscpTagValue { get; set; }

		/// <summary>
		/// A string, indicating the priority level for packets bound to your rule.     Can be &#39;low&#39;, &#39;normal&#39; or &#39;high&#39;.
		/// </summary>
		/// <value>A string, indicating the priority level for packets bound to your rule.     Can be &#39;low&#39;, &#39;normal&#39; or &#39;high&#39;.</value>
		[DataMember(Name = "priority", EmitDefaultValue = false)]
		public string Priority { get; set; }
	}
}
