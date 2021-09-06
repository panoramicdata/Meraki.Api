using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkAppliancePort
	/// </summary>
	[DataContract]
	public class NetworkAppliancePortUpdateRequest
	{
		/// <summary>
		/// Number
		/// </summary>
		[DataMember(Name = "number")]
		public int? Number { get; set; }

		/// <summary>
		/// The status of the port
		/// </summary>
		/// <value>The status of the port</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }
		/// <summary>
		/// Trunk port can Drop all Untagged traffic. When true, no VLAN is required. Access ports cannot have dropUntaggedTraffic set to true.
		/// </summary>
		/// <value>Trunk port can Drop all Untagged traffic. When true, no VLAN is required. Access ports cannot have dropUntaggedTraffic set to true.</value>
		[DataMember(Name = "dropUntaggedTraffic", EmitDefaultValue = false)]
		public bool? DropUntaggedTraffic { get; set; }
		/// <summary>
		/// The type of the port: &#39;access&#39; or &#39;trunk&#39;.
		/// </summary>
		/// <value>The type of the port: &#39;access&#39; or &#39;trunk&#39;.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; } = string.Empty;
		/// <summary>
		/// Native VLAN when the port is in Trunk mode. Access VLAN when the port is in Access mode.
		/// </summary>
		/// <value>Native VLAN when the port is in Trunk mode. Access VLAN when the port is in Access mode.</value>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public int? Vlan { get; set; }
		/// <summary>
		/// Comma-delimited list of the VLAN ID&#39;s allowed on the port, or &#39;all&#39; to permit all VLAN&#39;s on the port.
		/// </summary>
		/// <value>Comma-delimited list of the VLAN ID&#39;s allowed on the port, or &#39;all&#39; to permit all VLAN&#39;s on the port.</value>
		[DataMember(Name = "allowedVlans", EmitDefaultValue = false)]
		public string AllowedVlans { get; set; } = string.Empty;
		/// <summary>
		/// The name of the policy. Only applicable to Access ports. Valid values are: &#39;open&#39;, &#39;8021x-radius&#39;, &#39;mac-radius&#39;, &#39;hybris-radius&#39; for MX64 or Z3 or any MX supporting the per port authentication feature. Otherwise, &#39;open&#39; is the only valid value and &#39;open&#39; is the default value if the field is missing.
		/// </summary>
		/// <value>The name of the policy. Only applicable to Access ports. Valid values are: &#39;open&#39;, &#39;8021x-radius&#39;, &#39;mac-radius&#39;, &#39;hybris-radius&#39; for MX64 or Z3 or any MX supporting the per port authentication feature. Otherwise, &#39;open&#39; is the only valid value and &#39;open&#39; is the default value if the field is missing.</value>
		[DataMember(Name = "accessPolicy", EmitDefaultValue = false)]
		public string AccessPolicy { get; set; } = string.Empty;
	}
}
