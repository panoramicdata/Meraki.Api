namespace Meraki.Api.Data;

/// <summary>
/// Licensing Subscription Claim
/// </summary>
[DataContract]
public class LicensingSubscriptionClaimRequest
{
	/// <summary>
	/// Subscription description
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "claimKey")]
	public string ClaimKey { get; set; } = string.Empty;

	/// <summary>
	/// Extra details or notes about the subscription
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Friendly name to identify the subscription
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The id of the organization claiming the subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;
}