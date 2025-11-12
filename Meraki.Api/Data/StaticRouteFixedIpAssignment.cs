namespace Meraki.Api.Data;

/// <summary>
/// Static Route Fixed Ip Assignment
/// </summary>
[DataContract]
public class StaticRouteFixedIpAssignment
{
	/// <summary>
	/// Gets the ip
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ip")]
	public string? Ip { get; set; }

	/// <summary>
	/// Gets the name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
