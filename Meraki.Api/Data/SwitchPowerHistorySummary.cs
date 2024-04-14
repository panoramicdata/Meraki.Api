namespace Meraki.Api.Data;

[DataContract]

public class SwitchPowerHistorySummary
{
	/// <summary>
	/// Timestamp of the start of the interval.
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// The PoE power draw in watts for all switch ports in the organization for the given interval.
	/// </summary>
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}
