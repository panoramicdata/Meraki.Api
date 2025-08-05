namespace Meraki.Api.Data;

/// <summary>
/// Client details
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryItemClient
{
	/// <summary>
	/// Client Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}