namespace Meraki.Api.Data;

/// <summary>
/// Settings
/// </summary>
[DataContract]
public class WirelessRadioTwoFourGhzSettings
{
	/// <summary>
	/// Sets a manual channel for 2.4 GHz. Can be '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13' or '14' or null for using auto channel.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "channel")]
	public int? Channel { get; set; }

	/// <summary>
	/// Set a manual target power for 2.4 GHz. Can be between '5' or '30' or null for using auto power range.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "targetPower")]
	public float? TargetPower { get; set; }
}
