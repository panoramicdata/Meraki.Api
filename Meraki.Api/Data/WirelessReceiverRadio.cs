namespace Meraki.Api.Data;

/// <summary>
/// Add scanning API Radio
/// </summary>
[DataContract]
public class WirelessReceiverRadio
{
	/// <summary>
	/// Radio Type. Valid types are: Wi-Fi, Bluetooth enum = ["Bluetooth", "Wi-Fi"]
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}