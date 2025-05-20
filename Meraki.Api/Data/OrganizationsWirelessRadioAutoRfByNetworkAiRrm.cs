namespace Meraki.Api.Data;

/// <summary>
/// AI-RRM settings
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkAiRrm
{
	/// <summary>
	/// Time at which AI-RRM was last enabled in the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enablementDate")]
	public string EnablementDate { get; set; } = string.Empty;

	/// <summary>
	/// Toggle for enabling or disabling AI-RRM in a network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}