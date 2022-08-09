namespace Meraki.Api.Data;

/// <summary>
/// Settings
/// </summary>
[DataContract]
public class WirelessRadioFiveGhzSettings
{
	/// <summary>
	/// Sets a manual channel for 5 GHz. Can be '36', '40', '44', '48', '52', '56', '60', '64', '100', '104', '108', '112', '116', '120', '124', '128', '132', '136', '140', '144', '149', '153', '157', '161', '165', '169', '173' or '177' or null for using auto channel.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "channel")]
	public int? Channel { get; set; }

	/// <summary>
	/// Sets a manual channel for 5 GHz. Can be '0', '20', '40', '80' or '160' or null for using auto channel width.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "channelWidth")]
	public int? ChannelWidth { get; set; }

	/// <summary>
	/// Set a manual target power for 5 GHz. Can be between '8' or '30' or null for using auto power range.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "targetPower")]
	public double? TargetPower { get; set; }
}
