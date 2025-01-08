namespace Meraki.Api.Data;

/// <summary>
/// Smart Account
/// </summary>
[DataContract]
public class LicensingSubscriptionClaimSmartAccount
{
	/// <summary>
	/// Smart Account ID
	/// </summary>
	[Obsolete("Removed in Meraki API v1.53")]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public int Id { get; set; }

	/// <summary>
	/// The name of the smart account
	/// </summary>
	[Obsolete("Removed in Meraki API v1.53")]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Subscription Smart Account status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Smart Account data
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "account")]
	public LicensingSubscriptionClaimSmartAccountAccount Account { get; set; } = new();
}