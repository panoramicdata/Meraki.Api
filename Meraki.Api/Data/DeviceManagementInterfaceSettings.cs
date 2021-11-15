namespace Meraki.Api.Data;

[DataContract]
public class DeviceManagementInterfaceSettings
{
	/// <summary>
	/// Dynamic DNS Hostnames
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ddnsHostnames")]
	public DdnsHostnames? DdnsHostnames { get; set; }

	/// <summary>
	/// WAN 1 settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wan1")]
	public Wan? Wan1 { get; set; }

	/// <summary>
	/// WAN 2 settings (only for MX devices)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wan2")]
	public Wan? Wan2 { get; set; }
}
