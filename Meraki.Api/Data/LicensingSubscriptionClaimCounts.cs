namespace Meraki.Api.Data;

/// <summary>
/// Numeric breakdown of network and entitlement counts
/// </summary>
[DataContract]
public class LicensingSubscriptionClaimCounts
{
	/// <summary>
	/// Number of networks bound to this subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networks")]
	public int Networks { get; set; }

	/// <summary>
	/// Subscription expiration date
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endDate")]
	public LicensingSubscriptionClaimCountsSeats Seats { get; set; } = new();

}