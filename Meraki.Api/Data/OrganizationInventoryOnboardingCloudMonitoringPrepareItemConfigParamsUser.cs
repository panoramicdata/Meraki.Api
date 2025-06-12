namespace Meraki.Api.Data;

/// <summary>
/// User credentials used to connect to the device
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsUser
{
	/// <summary>
	/// The public key for the registered user
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publicKey")]
	public string PublicKey { get; set; } = string.Empty;

	/// <summary>
	/// The username added to Catalyst device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "username")]
	public string Username { get; set; } = string.Empty;

	/// <summary>
	/// Stores the user secret hash
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "secret")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsUserSecret Secret { get; set; } = new();
}
