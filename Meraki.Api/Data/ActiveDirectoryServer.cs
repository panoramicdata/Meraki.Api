namespace Meraki.Api.Data;

/// <summary>
/// The Active Directory servers to be used for authentication.
/// </summary>
[DataContract]
public class ActiveDirectoryServer
{
	/// <summary>
	/// (Optional) UDP port the Active Directory server listens on. By default, uses port 3268.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public int? Port { get; set; }

	/// <summary>
	/// IP address of your Active Directory server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = string.Empty;
}
