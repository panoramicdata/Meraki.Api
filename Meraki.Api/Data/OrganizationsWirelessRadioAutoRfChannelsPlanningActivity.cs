namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Radio AutoRf Channels Planning Activity
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfChannelsPlanningActivity
{
	/// <summary>
	/// The channel where the channel planning activity occured
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channel")]
	public int Channel { get; set; }

	/// <summary>
	/// The severity of the channel planning activity that occured (1 = most severe, 6 = least severe)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "severity")]
	public int Severity { get; set; }

	/// <summary>
	/// The band over which the channel planning activity occurred
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "band")]
	public string Band { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp of when the channel planning activity expires
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endsAt")]
	public string EndsAt { get; set; } = string.Empty;

	/// <summary>
	/// The event that caused the channel planning activity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reason")]
	public ActivityReason Reason { get; set; }

	/// <summary>
	/// Timestamp of when the channel planning activity was triggered
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startedAt")]
	public string StartedAt { get; set; } = string.Empty;

	/// <summary>
	/// The type of channel planning activity that occured
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Device data
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "device")]
	public OrganizationsWirelessRadioAutoRfChannelsPlanningActivityDevice Device { get; set; } = new();

	/// <summary>
	/// Network data
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationsWirelessRadioAutoRfChannelsPlanningActivityNetwork Network { get; set; } = new();
}
