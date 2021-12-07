namespace Meraki.Api.Data;

/// <summary>
/// Ranges
/// </summary>
[DataContract]
public class WirelessSsidOutageRange
{
	/// <summary>
	/// 24 hour time when the outage starts.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "startDay")]
	public string StartDay { get; set; } = string.Empty;

	/// <summary>
	/// Day of when the outage starts. Can be either full day name, or three letter abbreviation.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "startTime")]
	public string StartTime { get; set; } = string.Empty;

	/// <summary>
	/// Day of when the outage ends. Can be either full day name, or three letter abbreviation
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "endDay")]
	public string EndDay { get; set; } = string.Empty;

	/// <summary>
	/// 24 hour time when the outage ends.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "endTime")]
	public string EndTime { get; set; } = string.Empty;
}
