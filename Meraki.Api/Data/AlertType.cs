namespace Meraki.Api.Data;

/// <summary>
/// Alert Type
/// </summary>
[DataContract]
public enum AlertType
{
	[EnumMember(Value = "gatewayDown")]
	/// <summary>
	/// Gateway Down
	/// </summary>
	GatewayDown = 1,

	[EnumMember(Value = "gatewayToRepeater")]
	/// <summary>
	/// Gateway To Repeater
	/// </summary>
	GatewayToRepeater,

	[EnumMember(Value = "repeaterDown")]
	/// <summary>
	/// Repeater Down
	/// </summary>
	RepeaterDown,

	[EnumMember(Value = "rogueAp")]
	/// <summary>
	/// Rogue Ap
	/// </summary>
	RogueAp,

	[EnumMember(Value = "settingsChanged")]
	/// <summary>
	/// Settings Changed
	/// </summary>
	SettingsChanged,

	[EnumMember(Value = "snr")]
	/// <summary>
	/// Signal To Noise Ratio
	/// </summary>
	SignalToNoiseRatio,

	[EnumMember(Value = "highWirelessUsage")]
	/// <summary>
	/// High Wireless Usage
	/// </summary>
	HighWirelessUsage,

	[EnumMember(Value = "onboarding")]
	/// <summary>
	/// Onboarding
	/// </summary>
	Onboarding,

	[EnumMember(Value = "vpnConnectivityChange")]
	/// <summary>
	/// Vpn Connectivity Change
	/// </summary>
	VpnConnectivityChange,

	[EnumMember(Value = "usageAlert")]
	/// <summary>
	/// Usage Alert
	/// </summary>
	UsageAlert,

	[EnumMember(Value = "weeklyPresence")]
	/// <summary>
	/// Weekly Presence
	/// </summary>
	WeeklyPresence,

	[EnumMember(Value = "uplinkIp6Conflict")]
	/// <summary>
	/// Uplink Ip6Conflict
	/// </summary>
	UplinkIp6Conflict,

	[EnumMember(Value = "portDown")]
	/// <summary>
	/// Port Down
	/// </summary>
	PortDown,

	[EnumMember(Value = "powerSupplyDown")]
	/// <summary>
	/// Power Supply Down
	/// </summary>
	PowerSupplyDown,

	[EnumMember(Value = "rpsBackup")]
	/// <summary>
	/// Rps Backup
	/// </summary>
	RpsBackup,

	[EnumMember(Value = "udldError")]
	/// <summary>
	/// Udld Error
	/// </summary>
	UdldError,

	[EnumMember(Value = "portError")]
	/// <summary>
	/// Port Error
	/// </summary>
	PortError,

	[EnumMember(Value = "portSpeed")]
	/// <summary>
	/// Port Speed
	/// </summary>
	PortSpeed,

	[EnumMember(Value = "newDhcpServer")]
	/// <summary>
	/// New Dhcp Server
	/// </summary>
	NewDhcpServer,

	[EnumMember(Value = "switchDown")]
	/// <summary>
	/// Switch Down
	/// </summary>
	SwitchDown,

	[EnumMember(Value = "switchCriticalTemperature")]
	/// <summary>
	/// Switch Critical Temperature
	/// </summary>
	SwitchCriticalTemperature,

	[EnumMember(Value = "nodeHardwareFailure")]
	/// <summary>
	/// Node Hardware Failure
	/// </summary>
	NodeHardwareFailure,

	[EnumMember(Value = "cameraDown")]
	/// <summary>
	/// Camera Down
	/// </summary>
	CameraDown,

	[EnumMember(Value = "customMotionAlertRecipients")]
	/// <summary>
	/// Custom Motion Alert Recipients
	/// </summary>
	CustomMotionAlertRecipients,

	[EnumMember(Value = "sensorDown")]
	/// <summary>
	/// Sensor Down
	/// </summary>
	SensorDown,

	[EnumMember(Value = "sensorBatteryPercentage")]
	/// <summary>
	/// Sensor Battery Percentage
	/// </summary>
	SensorBatteryPercentage,

	[EnumMember(Value = "sensorProbeCable")]
	/// <summary>
	/// Sensor Probe Cable
	/// </summary>
	SensorProbeCable,

	[EnumMember(Value = "sensorWaterCable")]
	/// <summary>
	/// Sensor Water Cable
	/// </summary>
	SensorWaterCable,

	[EnumMember(Value = "sensorMagneticTampering")]
	/// <summary>
	/// Sensor Magnetic Tampering
	/// </summary>
	SensorMagneticTampering,

	[EnumMember(Value = "sensorBatteryCover")]
	/// <summary>
	/// Sensor Battery Cover
	/// </summary>
	SensorBatteryCover,

	[EnumMember(Value = "sensorUsbPowerCable")]
	/// <summary>
	/// Sensor Usb Power Cable
	/// </summary>
	SensorUsbPowerCable,

	[EnumMember(Value = "ampMalwareDetected")]
	/// <summary>
	/// Amp Malware Detected
	/// </summary>
	AmpMalwareDetected,

	[EnumMember(Value = "ampMalwareBlocked")]
	/// <summary>
	/// Amp Malware Blocked
	/// </summary>
	AmpMalwareBlocked,

	[EnumMember(Value = "applianceDown")]
	/// <summary>
	/// Appliance Down
	/// </summary>
	ApplianceDown,

	[EnumMember(Value = "failoverEvent")]
	/// <summary>
	/// Failover Event
	/// </summary>
	FailoverEvent,

	[EnumMember(Value = "dchpNoLeases")]
	/// <summary>
	/// Dhcp No Leases
	/// </summary>
	DhcpNoLeases,

	[EnumMember(Value = "rogueDhcp")]
	/// <summary>
	/// Rogue Dhcp
	/// </summary>
	RogueDhcp,

	[EnumMember(Value = "ipConflict")]
	/// <summary>
	/// Ip Conflict
	/// </summary>
	IpConflict,

	[EnumMember(Value = "ip6Conflict")]
	/// <summary>
	/// Ip6Conflict
	/// </summary>
	Ip6Conflict,

	[EnumMember(Value = "dhcp6naRenumber")]
	/// <summary>
	/// Dhcp6Na Renumber
	/// </summary>
	Dhcp6NaRenumber,

	[EnumMember(Value = "dhcp6pdRenumber")]
	/// <summary>
	/// Dhcp6Pd Renumber
	/// </summary>
	Dhcp6PdRenumber,

	[EnumMember(Value = "cellularUpDown")]
	/// <summary>
	/// Cellular Up Down
	/// </summary>
	CellularUpDown,

	[EnumMember(Value = "clientConnectivity")]
	/// <summary>
	/// Client Connectivity
	/// </summary>
	ClientConnectivity,

	[EnumMember(Value = "vrrp")]
	/// <summary>
	/// Vrrp
	/// </summary>
	Vrrp,

	[EnumMember(Value = "weeklyUmbrella")]
	/// <summary>
	/// Weekly Umbrella
	/// </summary>
	WeeklyUmbrella,

	[EnumMember(Value = "prefixStarvation")]
	/// <summary>
	/// Prefix Starvation
	/// </summary>
	PrefixStarvation,

	[EnumMember(Value = "cellularGatewayDown")]
	/// <summary>
	/// Cellular Gateway Down
	/// </summary>
	CellularGatewayDown,

	[EnumMember(Value = "newSplashSignup")]
	/// <summary>
	/// New Splash Signup
	/// </summary>
	NewSplashSignup,

	[EnumMember(Value = "swFound")]
	/// <summary>
	/// Sw Found
	/// </summary>
	SwFound,

	[EnumMember(Value = "cloudArchiveAlert")]
	/// <summary>
	/// Cloud Archive Alert
	/// </summary>
	CloudArchiveAlert,

	[EnumMember(Value = "pccOutage")]
	/// <summary>
	/// Pcc Outage
	/// </summary>
	PccOutage,

	[EnumMember(Value = "pccUnmanaged")]
	/// <summary>
	/// Pcc Unmanaged
	/// </summary>
	PccUnmanaged,

	[EnumMember(Value = "geofencingOut")]
	/// <summary>
	/// Geofencing Out
	/// </summary>
	GeofencingOut,

	[EnumMember(Value = "geofencingIn")]
	/// <summary>
	/// Geofencing In
	/// </summary>
	GeofencingIn,

	[EnumMember(Value = "pccEnrollment")]
	/// <summary>
	/// Pcc Enrollment
	/// </summary>
	PccEnrollment,

	[EnumMember(Value = "pccExpiredApnsCert")]
	/// <summary>
	/// Pcc Expired Apns Cert
	/// </summary>
	PccExpiredApnsCert,

	[EnumMember(Value = "motionAlert")]
	/// <summary>
	/// Motion Alert
	/// </summary>
	MotionAlert,

	[EnumMember(Value = "sensorPowerSavingScheduleSuccessEvent")]
	/// <summary>
	/// Sensor Power Saving Schedule Success Event
	/// </summary>
	SensorPowerSavingScheduleSuccessEvent,

	[EnumMember(Value = "sensorPowerSavingScheduleFailureEvent")]
	/// <summary>
	/// Sensor Power Saving Schedule Failure Event
	/// </summary>
	SensorPowerSavingScheduleFailureEvent,
}
