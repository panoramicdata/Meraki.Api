namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Radio AutoRf Channels Recalculate Request
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfChannelsRecalculateRequest
{
	/// <summary>
	/// A list of network ids (limit: 15).
	/// </summary>
	[DataMember(Name = "networkIds")]
	public List<string> NetworkIds { get; set; } = [];
}
