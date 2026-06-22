namespace Meraki.Api.Data;

/// <summary>
/// Billing
/// </summary>
[DataContract]
public class WirelessBilling
{
	/// <summary>
	/// Currency
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "currency")]
	public string Currency { get; set; } = string.Empty;

	/// <summary>
	/// Plans
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "plans")]
	public List<WirelessBillingPlan> Plans { get; set; } = [];

	/// <summary>
	/// Indicates whether the network has billing transactions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hasTransactions")]
	public bool? HasTransactions { get; set; }
}
