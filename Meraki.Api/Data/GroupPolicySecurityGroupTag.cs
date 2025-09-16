namespace Meraki.Api.Data;

/// <summary>
/// Undocumented
/// </summary>
[DataContract]
public class GroupPolicySecurityGroupTag
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}