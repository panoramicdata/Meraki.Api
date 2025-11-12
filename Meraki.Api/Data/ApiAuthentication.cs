namespace Meraki.Api.Data;

/// <summary>
/// Api Authentication
/// </summary>
[DataContract]
public class ApiAuthentication
{
	/// <summary>
	/// Gets the ip restrictions for keys
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipRestrictionsForKeys")]
	public IpRestrictionsForKeys IpRestrictionsForKeys { get; set; } = new();
}
