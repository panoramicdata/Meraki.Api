using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCellularGatewaySettingsSubnetPool
	/// </summary>
	[DataContract]
	public partial class NetworkCellularGatewaySettingsSubnetPoolUpdateRequest
	{
		/// <summary>
		/// Mask used for the subnet of all MGs in  this network.
		/// </summary>
		/// <value>Mask used for the subnet of all MGs in  this network.</value>
		[DataMember(Name = "mask", EmitDefaultValue = false)]
		public int? Mask { get; set; }
		/// <summary>
		/// CIDR of the pool of subnets. Each MG in this network will automatically pick a subnet from this pool.
		/// </summary>
		/// <value>CIDR of the pool of subnets. Each MG in this network will automatically pick a subnet from this pool.</value>
		[DataMember(Name = "cidr", EmitDefaultValue = false)]
		public string Cidr { get; set; }
	}
}
