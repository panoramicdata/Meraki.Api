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
	public bool? Enabled { get; set; }

	/// <summary>
	/// Username
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "username")]
	public string Username { get; set; } = "admin";

	/// <summary>
	/// A password used for Local Status Page(s). Set this null to clear the password.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "password")]
	// [JsonProperty(NullValueHandling = NullValueHandling.Include)] - not using this so that we don't accidentally clear passwords
	public string? Password { get; set; }
}
