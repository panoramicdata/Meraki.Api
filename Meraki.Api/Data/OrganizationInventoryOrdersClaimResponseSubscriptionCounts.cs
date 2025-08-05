namespace Meraki.Api.Data;

/// <summary>
/// Numeric breakdown of subscription counts
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersClaimResponseSubscriptionCounts
{
	/// <summary>
	/// Seat distribution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "seats")]
	public OrganizationInventoryOrdersClaimResponseSubscriptionCountsSeats Seats { get; set; } = new();
}
