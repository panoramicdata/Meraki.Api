using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkStaticRoute
	/// </summary>
	[DataContract]
	public partial class StaticRouteCreationRequest
	{
		/// <summary>
		/// The name of the new static route
		/// </summary>
		/// <value>The name of the new static route</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The subnet of the static route
		/// </summary>
		/// <value>The subnet of the static route</value>
		[DataMember(Name = "subnet", EmitDefaultValue = false)]
		public string Subnet { get; set; } = null!;

		/// <summary>
		/// The gateway IP (next hop) of the static route
		/// </summary>
		/// <value>The gateway IP (next hop) of the static route</value>
		[DataMember(Name = "gatewayIp", EmitDefaultValue = false)]
		public string GatewayIp { get; set; } = null!;
	}
}
