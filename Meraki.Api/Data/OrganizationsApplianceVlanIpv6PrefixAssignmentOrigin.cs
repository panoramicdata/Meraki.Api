namespace Meraki.Api.Data;

/// <summary>
/// The origin of the prefix
/// </summary>
[DataContract]
public class OrganizationsApplianceVlanIpv6PrefixAssignmentOrigin
{
	/// <summary>
	/// Type of the origin
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public OriginType Type { get; set; }

	/// <summary>
	/// Interfaces associated with the prefix
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interfaces")]
	public List<string> Interfaces { get; set; } = [];
}
