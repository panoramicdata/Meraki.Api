namespace Meraki.Api.Data;

/// <summary>
/// Wireless SSID speedburst settings
/// </summary>
[DataContract]
public class SpeedBurst
{
	/// <summary>
	/// Boolean indicating whether or not Wireless SSID speedburst is enabled. If disabled, upstream DNS will be used
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
