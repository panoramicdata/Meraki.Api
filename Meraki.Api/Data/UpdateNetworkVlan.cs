using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkVlan
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkVlan
	{
		/// <summary>
		/// The name of the VLAN
		/// </summary>
		/// <value>The name of the VLAN</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The subnet of the VLAN
		/// </summary>
		/// <value>The subnet of the VLAN</value>
		[DataMember(Name = "subnet", EmitDefaultValue = false)]
		public string Subnet { get; set; } = null!;

		/// <summary>
		/// The local IP of the appliance on the VLAN
		/// </summary>
		/// <value>The local IP of the appliance on the VLAN</value>
		[DataMember(Name = "applianceIp", EmitDefaultValue = false)]
		public string ApplianceIp { get; set; } = null!;

		/// <summary>
		/// The id of the desired group policy to apply to the VLAN
		/// </summary>
		/// <value>The id of the desired group policy to apply to the VLAN</value>
		[DataMember(Name = "groupPolicyId", EmitDefaultValue = false)]
		public string GroupPolicyId { get; set; } = null!;

		/// <summary>
		/// The translated VPN subnet if VPN and VPN subnet translation are enabled on the VLAN
		/// </summary>
		/// <value>The translated VPN subnet if VPN and VPN subnet translation are enabled on the VLAN</value>
		[DataMember(Name = "vpnNatSubnet", EmitDefaultValue = false)]
		public string VpnNatSubnet { get; set; } = null!;

		/// <summary>
		/// Gets or Sets DhcpHandling
		/// </summary>
		[DataMember(Name = "dhcpHandling", EmitDefaultValue = false)]
		public DhcpHandling DhcpHandling { get; set; }

		/// <summary>
		/// The IPs of the DHCP servers that DHCP requests should be relayed to
		/// </summary>
		/// <value>The IPs of the DHCP servers that DHCP requests should be relayed to</value>
		[DataMember(Name = "dhcpRelayServerIps", EmitDefaultValue = false)]
		public List<string> DhcpRelayServerIps { get; set; } = null!;

		/// <summary>
		/// Gets or Sets DhcpLeaseTime
		/// </summary>
		[DataMember(Name = "dhcpLeaseTime", EmitDefaultValue = false)]
		public DhcpLeaseTime DhcpLeaseTime { get; set; }

		/// <summary>
		/// Use DHCP boot options specified in other properties
		/// </summary>
		/// <value>Use DHCP boot options specified in other properties</value>
		[DataMember(Name = "dhcpBootOptionsEnabled", EmitDefaultValue = false)]
		public bool? DhcpBootOptionsEnabled { get; set; }

		/// <summary>
		/// DHCP boot option to direct boot clients to the server to load the boot file from
		/// </summary>
		/// <value>DHCP boot option to direct boot clients to the server to load the boot file from</value>
		[DataMember(Name = "dhcpBootNextServer", EmitDefaultValue = false)]
		public string DhcpBootNextServer { get; set; } = null!;

		/// <summary>
		/// DHCP boot option for boot filename
		/// </summary>
		/// <value>DHCP boot option for boot filename</value>
		[DataMember(Name = "dhcpBootFilename", EmitDefaultValue = false)]
		public string DhcpBootFilename { get; set; } = null!;

		/// <summary>
		/// The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details.
		/// </summary>
		/// <value>The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details.</value>
		[DataMember(Name = "fixedIpAssignments", EmitDefaultValue = false)]
		public object FixedIpAssignments { get; set; } = null!;

		/// <summary>
		/// The DHCP reserved IP ranges on the VLAN
		/// </summary>
		/// <value>The DHCP reserved IP ranges on the VLAN</value>
		[DataMember(Name = "reservedIpRanges", EmitDefaultValue = false)]
		public List<ReservedIpRange> ReservedIpRanges { get; set; } = null!;

		/// <summary>
		/// The DNS nameservers used for DHCP responses, either \&quot;upstream_dns\&quot;, \&quot;google_dns\&quot;, \&quot;opendns\&quot;, or a newline seperated string of IP addresses or domain names
		/// </summary>
		/// <value>The DNS nameservers used for DHCP responses, either \&quot;upstream_dns\&quot;, \&quot;google_dns\&quot;, \&quot;opendns\&quot;, or a newline seperated string of IP addresses or domain names</value>
		[DataMember(Name = "dnsNameservers", EmitDefaultValue = false)]
		public string DnsNameservers { get; set; } = null!;

		/// <summary>
		/// The list of DHCP options that will be included in DHCP responses. Each object in the list should have \&quot;code\&quot;, \&quot;type\&quot;, and \&quot;value\&quot; properties.
		/// </summary>
		/// <value>The list of DHCP options that will be included in DHCP responses. Each object in the list should have \&quot;code\&quot;, \&quot;type\&quot;, and \&quot;value\&quot; properties.</value>
		[DataMember(Name = "dhcpOptions", EmitDefaultValue = false)]
		public List<DhcpOption> DhcpOptions { get; set; } = null!;
	}
}
