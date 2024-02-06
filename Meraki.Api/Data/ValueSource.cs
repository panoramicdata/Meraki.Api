namespace Meraki.Api.Data;

/// <summary>
/// Source
/// </summary>
[DataContract]
public class ValueSource
{
	/// <summary>
	/// Nbar - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "nbar")]
	public object? Nbar { get; set; }

	/// <summary>
	/// E.g.: "any", "0" (also means "any"), "8080", "1-1024"
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public string? Port { get; set; }

	/// <summary>
	/// CIDR format address, or "any". E.g.: "192.168.10.0/24", "192.168.10.1" (same as "192.168.10.1/32"), "0.0.0.0/0" (same as "any")
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cidr")]
	public string? Cidr { get; set; }

	/// <summary>
	/// VLAN ID of the configured VLAN in the Meraki network. Currently only available under a template network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// Host ID in the VLAN, should be used along with 'vlan', and not exceed the vlan subnet capacity. Currently only available under a template network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public int? Host { get; set; }

	/// <summary>
	/// Meraki network ID. Currently only available under a template network, and the value should be ID of either same template network, or another template network currently. E.g.: "L_12345678".
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "network")]
	public string? Network { get; set; }
}
