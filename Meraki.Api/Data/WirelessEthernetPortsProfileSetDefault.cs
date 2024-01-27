namespace Meraki.Api.Data;

/// <summary>
/// Wireless Ethernet Ports Profile Set Default
/// </summary>
[DataContract]
public class WirelessEthernetPortsProfileSetDefault
{
	/// <summary>
	/// Profile Id
	/// </summary>
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;
}
