namespace Meraki.Api.Data;

/// <summary>
/// Length of time in seconds that the triggering state must persist before an alert is sent. Available options are 0 seconds, 1 minute, 2 minutes, 3 minutes, 4 minutes, 5 minutes, 10 minutes, 15 minutes, 30 minutes, 1 hour, 2 hours, 4 hours, and 8 hours. Default is 0.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SensorAlertConditionDuration
{
	/// <summary>
	/// 0 Seconds
	/// </summary>
	[EnumMember(Value = "0")]
	Seconds0,

	/// <summary>
	/// 1 Minute
	/// </summary>
	[EnumMember(Value = "60")]
	Seconds60,

	/// <summary>
	/// 2 Minutes
	/// </summary>
	[EnumMember(Value = "120")]
	Seconds120,

	/// <summary>
	/// 3 Minutes
	/// </summary>
	[EnumMember(Value = "180")]
	Seconds180,

	/// <summary>
	/// 4 Minutes
	/// </summary>
	[EnumMember(Value = "240")]
	Seconds240,

	/// <summary>
	/// 5 Minutes
	/// </summary>
	[EnumMember(Value = "300")]
	Seconds300,

	/// <summary>
	/// 10 Minutes
	/// </summary>
	[EnumMember(Value = "600")]
	Seconds600,

	/// <summary>
	/// 15 Minutes
	/// </summary>
	[EnumMember(Value = "900")]
	Seconds900,

	/// <summary>
	/// 30 Minutes
	/// </summary>
	[EnumMember(Value = "1800")]
	Seconds1800,

	/// <summary>
	/// 1 Hour
	/// </summary>
	[EnumMember(Value = "3600")]
	Seconds3600,

	/// <summary>
	/// 1.5 Hours
	/// </summary>
	[EnumMember(Value = "5400")]
	Seconds5400,

	/// <summary>
	/// 2 Hours
	/// </summary>
	[EnumMember(Value = "7200")]
	Seconds7200,

	/// <summary>
	/// 4 Hours
	/// </summary>
	[EnumMember(Value = "14400")]
	Seconds14400,

	/// <summary>
	/// 8 Hours
	/// </summary>
	[EnumMember(Value = "28800")]
	Seconds28800,
}