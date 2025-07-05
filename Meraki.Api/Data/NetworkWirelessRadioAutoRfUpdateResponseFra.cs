namespace Meraki.Api.Data;

/// <summary>
/// FRA settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateResponseFra
{
	/// <summary>
	/// Toggle to activate or deactivate FRA in a network, contingent on AI-RRM being enabled.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}