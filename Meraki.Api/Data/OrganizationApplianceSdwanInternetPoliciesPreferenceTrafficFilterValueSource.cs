namespace Meraki.Api.Data;

/// <summary>
/// Source of traffic filter
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValueSource
{
	/// <summary>
	/// Host ID in the VLAN. Should not exceed the VLAN subnet capacity. Must be used along with the "vlan" property and is currently only available under a template network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "host")]
	public long Host { get; set; }

	/// <summary>
	/// VLAN ID of the configured VLAN in the Meraki network. Cannot be used in combination with the "cidr" property and is currently only available under a template network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public long Vlan { get; set; }

	/// <summary>
	/// CIDR format address (e.g."192.168.10.1", which is the same as "192.168.10.1/32"), or "any". Cannot be used in combination with the "vlan" property
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cidr")]
	public string Cidr { get; set; }

	/// <summary>
	/// E.g.: "any", "0" (also means "any"), "8080", "1-1024"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;
}