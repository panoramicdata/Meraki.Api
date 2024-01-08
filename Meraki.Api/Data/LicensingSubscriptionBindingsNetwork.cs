namespace Meraki.Api.Data;

/// <summary>
/// Licensing Subscription Bindings Network
/// </summary>
[DataContract]
public class LicensingSubscriptionBindingsNetwork
{
	/// <summary>
	/// Network Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

}