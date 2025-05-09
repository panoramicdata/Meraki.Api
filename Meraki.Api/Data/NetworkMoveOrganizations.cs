namespace Meraki.Api.Data;

/// <summary>
/// Organizations involved in the network move
/// </summary>
[DataContract]
public class NetworkMoveOrganizations
{
	/// <summary>
	/// The organization from which the network is moved
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public NetworkMoveOrganizationsOrganization Source { get; set; } = new();

	/// <summary>
	/// The organization to which the network is moving
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "target")]
	public NetworkMoveOrganizationsOrganization Target { get; set; } = new();
}
