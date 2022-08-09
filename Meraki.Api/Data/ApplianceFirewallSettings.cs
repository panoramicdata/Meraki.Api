namespace Meraki.Api.Data;

/// <summary>
/// Appliance Firewall Settings
/// </summary>
[DataContract]
public class ApplianceFirewallSettings
{
	/// <summary>
	/// Spoofing Protection
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "spoofingProtection")]
	public ApplianceFirewallSettingsSpoofingProtection? SpoofingProtection { get; set; }
}
