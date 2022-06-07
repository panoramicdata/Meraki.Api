namespace Meraki.Api.Data;

/// <summary>
/// Client
/// </summary>
[DataContract]
public class DeviceClient
{
	/// <summary>
	/// Usage
	/// </summary>
	[DataMember(Name = "usage")]
	public Usage? Usage { get; set; }

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Ip
	/// </summary>
	[DataMember(Name = "ip")]
	public string? Ip { get; set; }

	/// <summary>
	/// User
	/// </summary>
	[DataMember(Name = "user")]
	public string? User { get; set; }

	/// <summary>
	/// Vlan
	/// </summary>
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// Named Vlan
	/// </summary>
	[DataMember(Name = "namedVlan")]
	public string? NamedVlan { get; set; }

	/// <summary>
	/// Mdns name
	/// </summary>
	[DataMember(Name = "mdnsName")]
	public string? MdnsName { get; set; }

	/// <summary>
	/// Dhcp host name
	/// </summary>
	[DataMember(Name = "dhcpHostname")]
	public string? DhcpHostname { get; set; }
}
