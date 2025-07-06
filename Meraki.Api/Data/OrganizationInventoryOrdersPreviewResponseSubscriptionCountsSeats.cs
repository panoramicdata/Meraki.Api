namespace Meraki.Api.Data;

/// <summary>
/// Seat distribution
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseSubscriptionCountsSeats
{
	/// <summary>
	/// Total number of seats provided by this subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limit")]
	public int Limit { get; set; }
}