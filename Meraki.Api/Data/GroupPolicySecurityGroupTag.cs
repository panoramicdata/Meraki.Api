namespace Meraki.Api.Data;

/// <summary>
/// Security Group Tag settings for group policy
/// </summary>
[DataContract]
public class GroupPolicySecurityGroupTag
{
	/// <summary>
	/// Whether security group tagging is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The security group tag value
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "value")]
	public int? Value { get; set; }
}