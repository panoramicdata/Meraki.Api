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
	public int? Threshold { get; set; }

	/// <summary>
	/// The period for the alert in seconds.
	/// Set for:
	/// - UsageAlert (e.g. 1200)
	/// </summary>
	[DataMember(Name = "period")]
	public int? PeriodSeconds { get; set; }

	/// <summary>
	/// Regex
	/// </summary>
	[DataMember(Name = "regex")]
	public string? Regex { get; set; }

	/// <summary>
	/// Alert Filter Clients
	/// </summary>
	[DataMember(Name = "clients")]
	public List<AlertFiltersClient>? Clients { get; set; }

	/// <summary>
	/// Tag
	/// </summary>
	[DataMember(Name = "tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// Min Duration
	/// </summary>
	[DataMember(Name = "minDuration")]
	public int? MinDuration { get; set; }

	/// <summary>
	/// Failure Type
	/// </summary>
	[DataMember(Name = "failureType")]
	public string? FailureType { get; set; }

	/// <summary>
	/// Loopback Window (in sec) - The summary description does not match the property name but it is as documented 2024-04-15
	/// </summary>
	[DataMember(Name = "lookbackWindow")]
	public int? LookbackWindow { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Priority
	/// </summary>
	[DataMember(Name = "priority")]
	public string? Priority { get; set; }

	/// <summary>
	/// Serials
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// SSID Number
	/// </summary>
	[DataMember(Name = "ssidNum")]
	public int? SsidNum { get; set; }

	/// <summary>
	/// Conditions
	/// </summary>
	[DataMember(Name = "conditions")]
	public List<AlertFiltersCondition>? Conditions { get; set; }
}