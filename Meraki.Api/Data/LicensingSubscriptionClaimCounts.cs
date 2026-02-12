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
	/// Seat distribution counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "seats")]
	public LicensingSubscriptionClaimCountsSeats Seats { get; set; } = new();

	/// <summary>
	/// Number of organizations bound to this subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizations")]
	public int Organizations { get; set; }
}