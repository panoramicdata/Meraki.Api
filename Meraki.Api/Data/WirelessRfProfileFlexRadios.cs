namespace Meraki.Api.Data;

/// <summary>
/// Flex Radio Settings
/// </summary>
[DataContract]
public class WirelessRfProfileFlexRadios
{
	/// <summary>
	/// Flex Radios By Model
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "byModel")]
	public List<WirelessRfProfileFlexRadiosByModel>? ByModel { get; set; }


}
