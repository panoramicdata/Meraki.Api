namespace Meraki.Api.Data;

/// <summary>
/// Access policy counts
/// </summary>
[DataContract]
public class AccessPolicyCounts
{
	/// <summary>
	/// Access policy counts ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public AccessPolicyCountsPorts? Ports { get; set; }

}
