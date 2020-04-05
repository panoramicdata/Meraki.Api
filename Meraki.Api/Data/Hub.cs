using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Hub
	/// </summary>
	[DataContract]
	public partial class Hub
	{
		/// <summary>
		/// The network ID of the hub.
		/// </summary>
		/// <value>The network ID of the hub.</value>
		[DataMember(Name = "hubId", EmitDefaultValue = false)]
		public string HubId { get; set; }
		/// <summary>
		/// Only valid in &#39;spoke&#39; mode. Indicates whether default route traffic should be sent to this hub.
		/// </summary>
		/// <value>Only valid in &#39;spoke&#39; mode. Indicates whether default route traffic should be sent to this hub.</value>
		[DataMember(Name = "useDefaultRoute", EmitDefaultValue = false)]
		public bool? UseDefaultRoute { get; set; }
	}
}
