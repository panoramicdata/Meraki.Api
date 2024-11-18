namespace Meraki.Api.Data;

/// <summary>
/// Enterprise agreement details
/// </summary>
[DataContract]
public class LicensingSubscriptionClaimEnterpriseAgreement
{
	/// <summary>
	/// List of suites included.Empty for non-EA subscriptions.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "suites")]
	public List<string> Suites { get; set; } = [];
}