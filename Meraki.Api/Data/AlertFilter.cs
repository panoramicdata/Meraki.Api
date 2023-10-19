namespace Meraki.Api.Data;

[DataContract]
public class AlertFilters
{
	/// <summary>
	/// A selector in a form dependent on the AlertType:
	/// SignalToNoiseRatio: (e.g. {\"configs\":[{\"duration\":5,\"threshold\":\"low\",\"ssidNum\":null}]} )
	/// HighWirelessUsage: (e.g. {\"configs\":[{\"duration\":5,\"threshold\":\"low\",\"ssidNum\":null}]} )
	/// Onboarding: (e.g. {\"smartSensitivity\":\"medium\",\"smartEnabled\":false,\"eventReminderPeriodSecs\":10800,\"configs\":[{\"duration\":15,\"threshold\":\"medium\",\"ssidNum\":null,\"assoc\":true,\"auth\":true,\"dhcp\":true,\"dns\":true}]} )
	/// PortDown: (e.g. "any port" )
	/// PortError: (e.g. "any port" )
	/// PortSpeed: (e.g. "any port" )
	/// </summary>
	[DataMember(Name = "selector")]
	public string? Selector { get; set; }

	/// <summary>
	/// The timeout in minutes for the alert.
	/// Set for:
	/// - GatewayDown
	/// - RepeaterDown
	/// - PortDown
	/// - SwitchDown
	/// - CameraDown
	/// - SensorDown
	/// </summary>
	[DataMember(Name = "timeout")]
	public int? TimeoutMinutes { get; set; }

	/// <summary>
	/// The threshold for the alert.
	/// Set for:
	/// - UsageAlert in bytes (e.g. 104857600)
	/// - SensorBatteryPercentage in %  (e.g. 5)
	/// </summary>
	[DataMember(Name = "threshold")]
	public long? Threshold { get; set; }

	/// <summary>
	/// The period for the alert in seconds.
	/// Set for:
	/// - UsageAlert (e.g. 1200)
	/// </summary>
	[DataMember(Name = "period")]
	public long? PeriodSeconds { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[DataMember(Name = "regex")]
	public string? Regex { get; set; }

	/// <summary>
	/// Alert Filter Clients
	/// </summary>
	[DataMember(Name = "clients")]
	public List<AlertFiltersClient>? Clients { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[DataMember(Name = "tag")]
	public string? Tag { get; set; }
}