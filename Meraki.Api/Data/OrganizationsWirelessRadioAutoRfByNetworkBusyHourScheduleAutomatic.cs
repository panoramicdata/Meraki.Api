namespace Meraki.Api.Data;

/// <summary>
/// Automatic Busy Hour settings
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkBusyHourScheduleAutomatic
{
	/// <summary>
	/// The hour that Automatic Busy Hour ends each day, in the network time zone
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "end")]
	public string End { get; set; } = string.Empty;

	/// <summary>
	/// The hour that Automatic Busy Hour starts each day, in the network time zone
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "start")]
	public string Start { get; set; } = string.Empty;
}