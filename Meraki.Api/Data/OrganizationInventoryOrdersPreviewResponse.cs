namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Orders Preview Response
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponse
{
	/// <summary>
	/// The secure unique order claim number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "claimId")]
	public string ClaimId { get; set; } = string.Empty;

	/// <summary>
	/// Order Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public string Number { get; set; } = string.Empty;

	/// <summary>
	/// All shipping information for this order
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "shipping")]
	public OrganizationInventoryOrdersPreviewResponseShipping Shipping { get; set; } = new();

	/// <summary>
	/// All subscriptions contained in this order
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subscriptions")]
	public List<OrganizationInventoryOrdersPreviewResponseSubscription> Subscriptions { get; set; } = [];
}
