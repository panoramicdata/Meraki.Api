namespace Meraki.Api.Data;

[DataContract]

public class SwitchPowerHistorySummary
{
	/// <summary>
	/// Timespan
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Draw
	/// </summary>
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}
