namespace Meraki.Api.Data;

[DataContract]
public enum AlertType
{
	[EnumMember(Value = "gatewayDown")]
	GatewayDown = 1,

	[EnumMember(Value = "gatewayToRepeater")]
	GatewayToRepeater,

	[EnumMember(Value = "repeaterDown")]
	RepeaterDown,

	[EnumMember(Value = "rogueAp")]
	RogueAp,

	[EnumMember(Value = "settingsChanged")]
	SettingsChanged,

	[EnumMember(Value = "snr")]
	SignalToNoiseRatio,

	[EnumMember(Value = "highWirelessUsage")]
	HighWirelessUsage,

	[EnumMember(Value = "onboarding")]
	Onboarding,

	[EnumMember(Value = "vpnConnectivityChange")]
	VpnConnectivityChange,

	[EnumMember(Value = "usageAlert")]
	UsageAlert,

	[EnumMember(Value = "weeklyPresence")]
	WeeklyPresence,

	[EnumMember(Value = "uplinkIp6Conflict")]
	UplinkIp6Conflict,

	[EnumMember(Value = "portDown")]
	PortDown,

	[EnumMember(Value = "powerSupplyDown")]
	PowerSupplyDown,

	[EnumMember(Value = "rpsBackup")]
	RpsBackup,

	[EnumMember(Value = "udldError")]
	UdldError,

	[EnumMember(Value = "portError")]
	PortError,

	[EnumMember(Value = "portSpeed")]
	PortSpeed,

	[EnumMember(Value = "newDhcpServer")]
	NewDhcpServer,

	[EnumMember(Value = "switchDown")]
	SwitchDown,

	[EnumMember(Value = "switchCriticalTemperature")]
	SwitchCriticalTemperature,

	[EnumMember(Value = "nodeHardwareFailure")]
	NodeHardwareFailure,

	[EnumMember(Value = "cameraDown")]
	CameraDown,

	[EnumMember(Value = "customMotionAlertRecipients")]
	CustomMotionAlertRecipients,

	[EnumMember(Value = "sensorDown")]
	SensorDown,

	[EnumMember(Value = "sensorBatteryPercentage")]
	SensorBatteryPercentage,

	[EnumMember(Value = "sensorProbeCable")]
	SensorProbeCable,

	[EnumMember(Value = "sensorWaterCable")]
	SensorWaterCable,

	[EnumMember(Value = "sensorMagneticTampering")]
	SensorMagneticTampering,

	[EnumMember(Value = "sensorBatteryCover")]
	SensorBatteryCover,

	[EnumMember(Value = "sensorUsbPowerCable")]
	SensorUsbPowerCable,

	[EnumMember(Value = "ampMalwareDetected")]
	AmpMalwareDetected,

	[EnumMember(Value = "ampMalwareBlocked")]
	AmpMalwareBlocked,

	[EnumMember(Value = "applianceDown")]
	ApplianceDown,

	[EnumMember(Value = "failoverEvent")]
	FailoverEvent,

	[EnumMember(Value = "dchpNoLeases")]
	DhcpNoLeases,

	[EnumMember(Value = "rogueDhcp")]
	RogueDhcp,

	[EnumMember(Value = "ipConflict")]
	IpConflict,

	[EnumMember(Value = "ip6Conflict")]
	Ip6Conflict,

	[EnumMember(Value = "dhcp6naRenumber")]
	Dhcp6NaRenumber,

	[EnumMember(Value = "dhcp6pdRenumber")]
	Dhcp6PdRenumber,

	[EnumMember(Value = "cellularUpDown")]
	CellularUpDown,
}