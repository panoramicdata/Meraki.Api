namespace Meraki.Api.Data;

/// <summary>
/// Stores the user secret hash
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsUserSecret
{
	/// <summary>
	/// The hashed secret
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hash")]
	public string Hash { get; set; } = string.Empty;
}