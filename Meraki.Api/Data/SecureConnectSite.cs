namespace Meraki.Api.Data;

/// <summary>
/// A Site
/// </summary>
[DataContract]
public class SecureConnectSite
{
	/// <summary>
	/// The address of the site
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// The device type of the site
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "deviceType")]
	public string DeviceType { get; set; } = string.Empty;

	/// <summary>
	/// Network ID, may not be unique in result set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Site name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The region to which the site is connected
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "region")]
	public string Region { get; set; } = string.Empty;

	/// <summary>
	/// The site's type (one of: 'Sigraki', 'MerakiSpoke', 'MerakiHub', 'MerakiTemplate', 'ViptelaSigSite', or 'ViptelaPrivateAccessSite')
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// The VPN type of the site
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vpnType")]
	public string VpnType { get; set; } = string.Empty;

	/// <summary>
	/// Whether the site has the default route set to true or false.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "defaultRoute")]
	public bool DefaultRoute { get; set; }

	/// <summary>
	/// Whether the site is already enrolled in Secure Connect
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enrolled")]
	public bool Enrolled { get; set; }
}