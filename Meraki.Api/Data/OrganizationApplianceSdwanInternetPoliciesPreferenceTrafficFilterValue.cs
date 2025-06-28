namespace Meraki.Api.Data;

/// <summary>
/// Value of traffic filter
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValue
{
	/// <summary>
	/// Protocol of the traffic filter. Must be one of: 'tcp', 'udp', 'icmp6' or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public FilterProtocol Protocol { get; set; }

	/// <summary>
	/// Destination of 'custom' type traffic filter
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destination")]
	public OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValueDestination Destination { get; set; } = new();

	/// <summary>
	/// Source of traffic filter
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public OrganizationApplianceSdwanInternetPoliciesPreferenceTrafficFilterValueSource Source { get; set; } = new();
}
