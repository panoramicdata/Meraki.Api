namespace Meraki.Api.Data;

/// <summary>
/// Authentication
/// </summary>
[DataContract]
public class StatusPageAuthentication
{
	/// <summary>
	/// Enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Username
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "username")]
	public string Usernname { get; set; } = string.Empty;
}
