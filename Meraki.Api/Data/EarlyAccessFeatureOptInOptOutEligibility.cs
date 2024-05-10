namespace Meraki.Api.Data;

/// <summary>
/// Descriptions of the early access feature
/// </summary>
[DataContract]
public class EarlyAccessFeatureOptInOptOutEligibility
{
	/// <summary>
	/// User friendly message regarding opt-out eligibility
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reason")]
	public string Reason { get; set; } = string.Empty;

	/// <summary>
	/// Condition flag to opt out from the feature
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "eligible")]
	public bool Eligible { get; set; }

	/// <summary>
	/// Additional help information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "help")]
	public EarlyAccessFeatureOptInOptOutEligibilityHelp Help { get; set; } = new();
}