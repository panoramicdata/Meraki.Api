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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;

	/// <summary>
	/// Limit Scope To Networks
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "limitScopeToNetworks")]
	public List<EarlyAccessFeatureOptInLimitScopeToNetwork> LimitScopeToNetworks { get; set; } = [];

	/// <summary>
	/// Created At
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	///Descriptions of the early access feature
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "optOutEligibility")]
	public EarlyAccessFeatureOptInOptOutEligibility OptOutEligibility { get; set; } = new();
}