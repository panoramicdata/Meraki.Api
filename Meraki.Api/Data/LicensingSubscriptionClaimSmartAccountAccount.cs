namespace Meraki.Api.Data;

/// <summary>
/// Smart Account Account
/// </summary>
[DataContract]
public class LicensingSubscriptionClaimSmartAccountAccount
{
	/// <summary>
	/// The domain of the Smart Account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "domain")]
	public string Domain { get; set; } = string.Empty;

	/// <summary>
	/// Smart Account ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the smart account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}