namespace Meraki.Api.Data;

/// <summary>
/// Seat distribution
/// </summary>
[DataContract]
public class LicensingSubscriptionClaimCountsSeats
{
	/// <summary>
	/// Number of seats in use
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assigned")]
	public int Assigned { get; set; }

	/// <summary>
	/// Number of seats available for use
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "available")]
	public int Available { get; set; }

	/// <summary>
	/// Total number of seats provided by this subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limit")]
	public int Limit { get; set; }

}