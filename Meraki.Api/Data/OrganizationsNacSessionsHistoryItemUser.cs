namespace Meraki.Api.Data;

/// <summary>
/// User details
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryItemUser
{
	/// <summary>
	/// User Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}