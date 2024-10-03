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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public int Id { get; set; }

	/// <summary>
	/// The name of the smart account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}