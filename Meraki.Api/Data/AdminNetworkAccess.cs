namespace Meraki.Api.Data;

/// <summary>
/// An admin's network access
/// </summary>
[DataContract]
public class AdminNetworkAccess : IdentifiedItem
{
	/// <summary>
	/// Network access permissions
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "access")]
	public AccessPrivilege Access { get; set; }
}
