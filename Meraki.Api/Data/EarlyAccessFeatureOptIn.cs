namespace Meraki.Api.Data;

/// <summary>
/// Early Access Feature Opt In
/// </summary>
[DataContract]
public class EarlyAccessFeatureOptIn : IdentifiedItem
{
	/// <summary>
	/// Short Name.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; } = string.Empty;

	/// <summary>
	/// Limit Scope To Networks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limitScopeToNetworks")]
	public List<EarlyAccessFeatureOptInLimitScopeToNetwork> LimitScopeToNetworks { get; } = new();

	/// <summary>
	/// Created At
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; }
}