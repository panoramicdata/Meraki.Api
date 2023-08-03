namespace Meraki.Api.Data;

/// <summary>
/// Flex Radio Settings By Model
/// </summary>
[DataContract]
public class WirelessRfProfileFlexRadiosByModel
{
	/// <summary>
	/// Model of the AP
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// MBand to use for each flex radio. For example, ['6'] will set the AP's first flex radio to 6 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bands")]
	public List<WirelessRfProfileFlexRadiosByModelBand>? Bands { get; set; }
}
