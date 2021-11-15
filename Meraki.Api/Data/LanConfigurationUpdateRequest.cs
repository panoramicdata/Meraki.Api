namespace Meraki.Api.Data;

/// <summary>
/// LAN configuration
/// </summary>
[DataContract]
public class LanConfigurationUpdateRequest
{
	/// <summary>
	/// Subnet
	/// </summary>
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// Appliance ip
	/// </summary>
	[DataMember(Name = "applianceIp")]
	public string ApplianceIp { get; set; } = string.Empty;
}
