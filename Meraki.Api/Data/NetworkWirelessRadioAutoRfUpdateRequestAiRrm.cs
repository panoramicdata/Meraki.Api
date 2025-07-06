namespace Meraki.Api.Data;

/// <summary>
/// AI-RRM settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequestAiRrm
{
	/// <summary>
	/// Toggle for enabling or disabling AI-RRM in a network
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}