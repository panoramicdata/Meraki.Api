namespace Meraki.Api.Data;

/// <summary>
/// Administered Identites Me
/// </summary>
[DataContract]
public class AdministeredIdentitiesMe
{
	/// <summary>
	/// User email
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// Last seen active on Dashboard UI
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUsedDashboardAt")]
	public string LastUsedDashboardAt { get; set; } = string.Empty;

	/// <summary>
	/// Username
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Authentication info
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authentication")]
	public AdministeredIdentitiesMeAuthentication Authentication { get; set; } = new();
}
