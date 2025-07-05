namespace Meraki.Api.Data;

/// <summary>
/// Numeric breakdown of subscription counts
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseSubscriptionCounts
{
	/// <summary>
	/// Seat distribution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "seats")]
	public OrganizationInventoryOrdersPreviewResponseSubscriptionCountsSeats Seats { get; set; } = new();
}
