namespace Meraki.Api.Data;

/// <summary>
/// Authorization details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthorization
{
	/// <summary>
	/// Authorization Profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profile")]
	public string Profile { get; set; } = string.Empty;

	/// <summary>
	/// Authorization Rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rule")]
	public string Rule { get; set; } = string.Empty;
}