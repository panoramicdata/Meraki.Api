namespace Meraki.Api.Data;

/// <summary>
/// Appliance Firewall Settings Spoofing Protection
/// </summary>
[DataContract]
public class ApplianceFirewallSettingsSpoofingProtection
{
	/// <summary>
	/// IpSourceGuard
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipSourceGuard")]
	public ApplianceFirewallSettingsSpoofingProtectionIpSourceGuard? IpSourceGuard { get; set; }
}
