namespace Meraki.Api.Data;

/// <summary>
/// Licensing Subscrption Bind Request
/// </summary>
[DataContract]
public class LicensingSubscriptionBindRequest
{
	/// <summary>
	/// List of network ids to bind to the subscription
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkIds")]
	public List<string> NetworkIds { get; set; } = [];

	/// <summary>
	/// Check if the provided networks can be bound to the subscription. Returns any licensing problems and does not commit the results.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "validate")]
	public bool? Validate { get; set; }
}