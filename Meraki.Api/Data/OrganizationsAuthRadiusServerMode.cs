namespace Meraki.Api.Data;

/// <summary>
/// Available server mode
/// </summary>
[DataContract]
public class OrganizationsAuthRadiusServerMode
{
	/// <summary>
	/// TCP port number for the corresponding server mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public int Port { get; set; }

	/// <summary>
	/// Type of server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public ServerType Mode { get; set; }
}
