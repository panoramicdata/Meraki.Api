namespace Meraki.Api.Data;

/// <summary>
/// Destination of 'custom' type traffic filter
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValueDestination
{
	/// <summary>
	/// CIDR format address (e.g."192.168.10.1", which is the same as "192.168.10.1/32"), or "any"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cidr")]
	public string Cidr { get; set; } = string.Empty;

	/// <summary>
	/// E.g.: "any", "0" (also means "any"), "8080", "1-1024"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// List of application objects (either majorApplication or nbar)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "applications")]
	public List<OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValueDestinationApplication> Applications { get; set; } = [];
}
