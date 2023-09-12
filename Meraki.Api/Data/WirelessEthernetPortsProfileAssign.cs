namespace Meraki.Api.Data;

/// <summary>
/// Wireless Ethernet Ports Profile Assignment
/// </summary>
[DataContract]
public class WirelessEthernetPortsProfileAssign
{
	/// <summary>
	/// Profile Id
	/// </summary>
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;

	/// <summary>
	/// List of AP serials
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

}
