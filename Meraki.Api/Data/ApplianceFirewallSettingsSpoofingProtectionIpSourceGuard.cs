namespace Meraki.Api.Data;

/// <summary>
/// Appliance Firewall Settings Spoofing Protection
/// </summary>
[DataContract]
public class ApplianceFirewallSettingsSpoofingProtectionIpSourceGuard
{
	/// <summary>
	/// Mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }
}
