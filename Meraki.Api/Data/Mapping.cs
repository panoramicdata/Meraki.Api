using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Mapping
	/// </summary>
	[DataContract]
	public partial class Mapping
	{
		/// <summary>
		/// The Differentiated Services Code Point (DSCP) tag in the IP header that will be mapped to a particular Class-of-Service (CoS) queue. Value can be in the range of 0 to 63 inclusive.
		/// </summary>
		/// <value>The Differentiated Services Code Point (DSCP) tag in the IP header that will be mapped to a particular Class-of-Service (CoS) queue. Value can be in the range of 0 to 63 inclusive.</value>
		[DataMember(Name = "dscp", EmitDefaultValue = false)]
		public int? Dscp { get; set; }
		/// <summary>
		/// The actual layer-2 CoS queue the DSCP value is mapped to. These are not bits set on outgoing frames. Value can be in the range of 0 to 5 inclusive.
		/// </summary>
		/// <value>The actual layer-2 CoS queue the DSCP value is mapped to. These are not bits set on outgoing frames. Value can be in the range of 0 to 5 inclusive.</value>
		[DataMember(Name = "cos", EmitDefaultValue = false)]
		public int? Cos { get; set; }
		/// <summary>
		/// Label for the mapping (optional).
		/// </summary>
		/// <value>Label for the mapping (optional).</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string? Title { get; set; }
	}
}
