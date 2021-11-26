namespace Meraki.Api.Data;

/// <summary>
/// Plans
/// </summary>
[DataContract]
public class WirelessBillingPlan : IdentifiedItem
{
	/// <summary>
	/// Price
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "price")]
	public string Price { get; set; } = string.Empty;

	/// <summary>
	/// Time limit
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "timeLimit")]
	public string TimeLimit { get; set; } = string.Empty;

	/// <summary>
	/// Bandwidth limits
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bandwidthLimits")]
	public BandwidthLimit BandwidthLimits { get; set; } = new();
}
