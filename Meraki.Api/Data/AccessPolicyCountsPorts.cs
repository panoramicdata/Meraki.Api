namespace Meraki.Api.Data;

/// <summary>
/// Access policy counts ports
/// </summary>
[DataContract]
public class AccessPolicyCountsPorts
{
	/// <summary>
	/// Access policy counts ports with this policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "withThisPolicy")]
	public int? WithThisPolicy { get; set; }

}
