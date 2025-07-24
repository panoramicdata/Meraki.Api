namespace Meraki.Api.Data;

/// <summary>
/// User details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsUser
{
	/// <summary>
	/// User Groups
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groups")]
	public string Groups { get; set; } = string.Empty;

	/// <summary>
	/// User Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// User IDP
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "idp")]
	public string Idp { get; set; } = string.Empty;
}