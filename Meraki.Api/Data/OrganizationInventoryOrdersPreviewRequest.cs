namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Orders Preview Request
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewRequest
{
	/// <summary>
	/// The unique order claim id
	/// </summary>
	[DataMember(Name = "claimId")]
	public string ClaimId { get; set; } = string.Empty;
}
