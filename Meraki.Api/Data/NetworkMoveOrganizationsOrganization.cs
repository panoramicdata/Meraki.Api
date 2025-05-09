namespace Meraki.Api.Data;

/// <summary>
/// Organization involved in the network move
/// </summary>
[DataContract]
public class NetworkMoveOrganizationsOrganization
{
	/// <summary>
	/// ID of the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}