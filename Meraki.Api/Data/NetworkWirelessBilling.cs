namespace Meraki.Api.Data;

/// <summary>
/// Billing
/// </summary>
[DataContract]
public class NetworkWirelessBilling
{
	/// <summary>
	/// Currency
	/// </summary>
	[DataMember(Name = "currency")]
	public string Currency { get; set; } = string.Empty;

	/// <summary>
	/// Plans
	/// </summary>
	[DataMember(Name = "plans")]
	public List<Plans> Plans { get; set; } = new();
}
