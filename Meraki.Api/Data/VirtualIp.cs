namespace Meraki.Api.Data;

/// <summary>
/// The WAN virtual IP
/// </summary>
[DataContract]
public class VirtualIp
{
	/// <summary>
	/// The Ip
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "ip")]
	public string? Ip { get; set; }

	/// <summary>
	/// The Subnet
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }
}
