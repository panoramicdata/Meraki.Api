using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Peer
	/// </summary>
	[DataContract]
	public class ThirdPartyVpnPeer
	{
		/// <summary>
		/// The name of the VPN peer
		/// </summary>
		/// <value>The name of the VPN peer</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The public IP of the VPN peer
		/// </summary>
		/// <value>The public IP of the VPN peer</value>
		[DataMember(Name = "publicIp", EmitDefaultValue = false)]
		public string PublicIp { get; set; } = null!;

		/// <summary>
		/// [optional] The remote ID is used to identify the connecting VPN peer. This can either be a valid IPv4 Address, FQDN or User FQDN.
		/// </summary>
		/// <value>[optional] The remote ID is used to identify the connecting VPN peer. This can either be a valid IPv4 Address, FQDN or User FQDN.</value>
		[DataMember(Name = "remoteId", EmitDefaultValue = false)]
		public string RemoteId { get; set; } = null!;

		/// <summary>
		/// The list of the private subnets of the VPN peer
		/// </summary>
		/// <value>The list of the private subnets of the VPN peer</value>
		[DataMember(Name = "privateSubnets", EmitDefaultValue = false)]
		public List<string> PrivateSubnets { get; set; } = new List<string>();

		/// <summary>
		/// Gets or Sets IpsecPolicies
		/// </summary>
		[DataMember(Name = "ipsecPolicies", EmitDefaultValue = false)]
		public IpsecPolicies IpsecPolicies { get; set; } = null!;

		/// <summary>
		/// One of the following available presets: &#39;default&#39;, &#39;aws&#39;, &#39;azure&#39;. If this is provided, the &#39;ipsecPolicies&#39; parameter is ignored.
		/// </summary>
		/// <value>One of the following available presets: &#39;default&#39;, &#39;aws&#39;, &#39;azure&#39;. If this is provided, the &#39;ipsecPolicies&#39; parameter is ignored.</value>
		[DataMember(Name = "ipsecPoliciesPreset", EmitDefaultValue = false)]
		public string IpsecPoliciesPreset { get; set; } = null!;

		/// <summary>
		/// The shared secret with the VPN peer
		/// </summary>
		/// <value>The shared secret with the VPN peer</value>
		[DataMember(Name = "secret", EmitDefaultValue = false)]
		public string Secret { get; set; } = null!;

		/// <summary>
		/// A list of network tags that will connect with this peer. Use [&#39;all&#39;] for all networks. Use [&#39;none&#39;] for no networks. If not included, the default is [&#39;all&#39;].
		/// </summary>
		/// <value>A list of network tags that will connect with this peer. Use [&#39;all&#39;] for all networks. Use [&#39;none&#39;] for no networks. If not included, the default is [&#39;all&#39;].</value>
		[DataMember(Name = "networkTags", EmitDefaultValue = false)]
		public List<string> NetworkTags { get; set; } = new List<string>();
	}
}