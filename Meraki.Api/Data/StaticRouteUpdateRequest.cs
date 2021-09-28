using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkStaticRoute
	/// </summary>
	[DataContract]
	public class StaticRouteUpdateRequest
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string? Id { get; set; }

		/// <summary>
		/// Network id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string? NetworkId { get; set; }

		/// <summary>
		/// The name of the static route
		/// </summary>
		/// <value>The name of the static route</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The subnet of the static route
		/// </summary>
		/// <value>The subnet of the static route</value>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = null!;

		/// <summary>
		/// The gateway IP (next hop) of the static route
		/// </summary>
		/// <value>The gateway IP (next hop) of the static route</value>
		[DataMember(Name = "gatewayIp")]
		public string GatewayIp { get; set; } = null!;

		/// <summary>
		/// The enabled state of the static route
		/// </summary>
		/// <value>The enabled state of the static route</value>
		[DataMember(Name = "enabled")]
		public bool? Enabled { get; set; }

		/// <summary>
		/// The DHCP fixed IP assignments on the static route. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details.
		/// </summary>
		/// <value>The DHCP fixed IP assignments on the static route. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details.</value>
		[DataMember(Name = "fixedIpAssignments")]
		public object FixedIpAssignments { get; set; } = null!;

		/// <summary>
		/// The DHCP reserved IP ranges on the static route
		/// </summary>
		/// <value>The DHCP reserved IP ranges on the static route</value>
		[DataMember(Name = "reservedIpRanges")]
		public List<ReservedIpRange> ReservedIpRanges { get; set; } = null!;
	}
}
