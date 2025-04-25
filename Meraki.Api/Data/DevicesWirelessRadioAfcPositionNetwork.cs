namespace Meraki.Api.Data;

/// <summary>
/// Network of device
/// </summary>
public class DevicesWirelessRadioAfcPositionNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}