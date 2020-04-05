using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule8
	/// </summary>
	[DataContract]
	public partial class Rule8
	{
		/// <summary>
		/// A descriptive name for the rule
		/// </summary>
		/// <value>A descriptive name for the rule</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }
		/// <summary>
		/// The IP address that will be used to access the internal resource from the WAN
		/// </summary>
		/// <value>The IP address that will be used to access the internal resource from the WAN</value>
		[DataMember(Name = "publicIp", EmitDefaultValue = false)]
		public string PublicIp { get; set; }
		/// <summary>
		/// The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN
		/// </summary>
		/// <value>The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN</value>
		[DataMember(Name = "lanIp", EmitDefaultValue = false)]
		public string LanIp { get; set; }
		/// <summary>
		/// Gets or Sets Uplink
		/// </summary>
		[DataMember(Name = "uplink", EmitDefaultValue = false)]
		public WanUplink Uplink { get; set; }
		/// <summary>
		/// The ports this mapping will provide access on, and the remote IPs that will be allowed access to the resource
		/// </summary>
		/// <value>The ports this mapping will provide access on, and the remote IPs that will be allowed access to the resource</value>
		[DataMember(Name = "allowedInbound", EmitDefaultValue = false)]
		public List<AllowedInbound> AllowedInbound { get; set; }
	}
}
