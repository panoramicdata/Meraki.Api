namespace Meraki.Api.Data;

/// <summary>
/// Alert Type
/// </summary>
[DataContract]
public enum AlertType
{
	/// <summary>
	/// Gateway Down
	/// </summary>
	[EnumMember(Value = "gatewayDown")]
	GatewayDown = 1,


	/// <summary>
	/// Gateway To Repeater
	/// </summary>
	[EnumMember(Value = "gatewayToRepeater")]
	GatewayToRepeater,


	/// <summary>
	/// Repeater Down
	/// </summary>
	[EnumMember(Value = "repeaterDown")]
	RepeaterDown,


	/// <summary>
	/// Rogue Ap
	/// </summary>
	[EnumMember(Value = "rogueAp")]
	RogueAp,


	/// <summary>
	/// Settings Changed
	/// </summary>
	[EnumMember(Value = "settingsChanged")]
	SettingsChanged,


	/// <summary>
	/// Signal To Noise Ratio
	/// </summary>
	[EnumMember(Value = "snr")]
	SignalToNoiseRatio,


	/// <summary>
	/// High Wireless Usage
	/// </summary>
	[EnumMember(Value = "highWirelessUsage")]
	HighWirelessUsage,


	/// <summary>
	/// Onboarding
	/// </summary>
	[EnumMember(Value = "onboarding")]
	Onboarding,


	/// <summary>
	/// Vpn Connectivity Change
	/// </summary>
	[EnumMember(Value = "vpnConnectivityChange")]
	VpnConnectivityChange,


	/// <summary>
	/// Usage Alert
	/// </summary>
	[EnumMember(Value = "usageAlert")]
	UsageAlert,


	/// <summary>
	/// Weekly Presence
	/// </summary>
	[EnumMember(Value = "weeklyPresence")]
	WeeklyPresence,


	/// <summary>
	/// Uplink Ip6Conflict
	/// </summary>
	[EnumMember(Value = "uplinkIp6Conflict")]
	UplinkIp6Conflict,


	/// <summary>
	/// Port Down
	/// </summary>
	[EnumMember(Value = "portDown")]
	PortDown,


	/// <summary>
	/// Power Supply Down
	/// </summary>
	[EnumMember(Value = "powerSupplyDown")]
	PowerSupplyDown,


	/// <summary>
	/// Rps Backup
	/// </summary>
	[EnumMember(Value = "rpsBackup")]
	RpsBackup,


	/// <summary>
	/// Udld Error
	/// </summary>
	[EnumMember(Value = "udldError")]
	UdldError,


	/// <summary>
	/// Port Error
	/// </summary>
	[EnumMember(Value = "portError")]
	PortError,


	/// <summary>
	/// Port Speed
	/// </summary>
	[EnumMember(Value = "portSpeed")]
	PortSpeed,


	/// <summary>
	/// New Dhcp Server
	/// </summary>
	[EnumMember(Value = "newDhcpServer")]
	NewDhcpServer,


	/// <summary>
	/// Switch Down
	/// </summary>
	[EnumMember(Value = "switchDown")]
	SwitchDown,


	/// <summary>
	/// Switch Critical Temperature
	/// </summary>
	[EnumMember(Value = "switchCriticalTemperature")]
	SwitchCriticalTemperature,


	/// <summary>
	/// Node Hardware Failure
	/// </summary>
	[EnumMember(Value = "nodeHardwareFailure")]
	NodeHardwareFailure,


	/// <summary>
	/// Camera Down
	/// </summary>
	[EnumMember(Value = "cameraDown")]
	CameraDown,


	/// <summary>
	/// Custom Motion Alert Recipients
	/// </summary>
	[EnumMember(Value = "customMotionAlertRecipients")]
	CustomMotionAlertRecipients,


	/// <summary>
	/// Sensor Down
	/// </summary>
	[EnumMember(Value = "sensorDown")]
	SensorDown,


	/// <summary>
	/// Sensor Battery Percentage
	/// </summary>
	[EnumMember(Value = "sensorBatteryPercentage")]
	SensorBatteryPercentage,


	/// <summary>
	/// Sensor Probe Cable
	/// </summary>
	[EnumMember(Value = "sensorProbeCable")]
	SensorProbeCable,


	/// <summary>
	/// Sensor Water Cable
	/// </summary>
	[EnumMember(Value = "sensorWaterCable")]
	SensorWaterCable,


	/// <summary>
	/// Sensor Magnetic Tampering
	/// </summary>
	[EnumMember(Value = "sensorMagneticTampering")]
	SensorMagneticTampering,


	/// <summary>
	/// Sensor Battery Cover
	/// </summary>
	[EnumMember(Value = "sensorBatteryCover")]
	SensorBatteryCover,


	/// <summary>
	/// Sensor Usb Power Cable
	/// </summary>
	[EnumMember(Value = "sensorUsbPowerCable")]
	SensorUsbPowerCable,


	/// <summary>
	/// Amp Malware Detected
	/// </summary>
	[EnumMember(Value = "ampMalwareDetected")]
	AmpMalwareDetected,


	/// <summary>
	/// Amp Malware Blocked
	/// </summary>
	[EnumMember(Value = "ampMalwareBlocked")]
	AmpMalwareBlocked,


	/// <summary>
	/// Appliance Down
	/// </summary>
	[EnumMember(Value = "applianceDown")]
	ApplianceDown,


	/// <summary>
	/// Failover Event
	/// </summary>
	[EnumMember(Value = "failoverEvent")]
	FailoverEvent,


	/// <summary>
	/// Dhcp No Leases
	/// </summary>
	[EnumMember(Value = "dchpNoLeases")]
	DhcpNoLeases,


	/// <summary>
	/// Rogue Dhcp
	/// </summary>
	[EnumMember(Value = "rogueDhcp")]
	RogueDhcp,


	/// <summary>
	/// Ip Conflict
	/// </summary>
	[EnumMember(Value = "ipConflict")]
	IpConflict,


	/// <summary>
	/// Ip6Conflict
	/// </summary>
	[EnumMember(Value = "ip6Conflict")]
	Ip6Conflict,


	/// <summary>
	/// Dhcp6Na Renumber
	/// </summary>
	[EnumMember(Value = "dhcp6naRenumber")]
	Dhcp6NaRenumber,


	/// <summary>
	/// Dhcp6Pd Renumber
	/// </summary>
	[EnumMember(Value = "dhcp6pdRenumber")]
	Dhcp6PdRenumber,


	/// <summary>
	/// Cellular Up Down
	/// </summary>
	[EnumMember(Value = "cellularUpDown")]
	CellularUpDown,


	/// <summary>
	/// Client Connectivity
	/// </summary>
	[EnumMember(Value = "clientConnectivity")]
	ClientConnectivity,


	/// <summary>
	/// Vrrp
	/// </summary>
	[EnumMember(Value = "vrrp")]
	Vrrp,


	/// <summary>
	/// Weekly Umbrella
	/// </summary>
	[EnumMember(Value = "weeklyUmbrella")]
	WeeklyUmbrella,


	/// <summary>
	/// Prefix Starvation
	/// </summary>
	[EnumMember(Value = "prefixStarvation")]
	PrefixStarvation,


	/// <summary>
	/// Cellular Gateway Down
	/// </summary>
	[EnumMember(Value = "cellularGatewayDown")]
	CellularGatewayDown,


	/// <summary>
	/// New Splash Signup
	/// </summary>
	[EnumMember(Value = "newSplashSignup")]
	NewSplashSignup,


	/// <summary>
	/// Sw Found
	/// </summary>
	[EnumMember(Value = "swFound")]
	SwFound,


	/// <summary>
	/// Cloud Archive Alert
	/// </summary>
	[EnumMember(Value = "cloudArchiveAlert")]
	CloudArchiveAlert,


	/// <summary>
	/// Pcc Outage
	/// </summary>
	[EnumMember(Value = "pccOutage")]
	PccOutage,


	/// <summary>
	/// Pcc Unmanaged
	/// </summary>
	[EnumMember(Value = "pccUnmanaged")]
	PccUnmanaged,


	/// <summary>
	/// Geofencing Out
	/// </summary>
	[EnumMember(Value = "geofencingOut")]
	GeofencingOut,


	/// <summary>
	/// Geofencing In
	/// </summary>
	[EnumMember(Value = "geofencingIn")]
	GeofencingIn,


	/// <summary>
	/// Pcc Enrollment
	/// </summary>
	[EnumMember(Value = "pccEnrollment")]
	PccEnrollment,


	/// <summary>
	/// Pcc Expired Apns Cert
	/// </summary>
	[EnumMember(Value = "pccExpiredApnsCert")]
	PccExpiredApnsCert,


	/// <summary>
	/// Motion Alert
	/// </summary>
	[EnumMember(Value = "motionAlert")]
	MotionAlert,


	/// <summary>
	/// Sensor Power Saving Schedule Success Event
	/// </summary>
	[EnumMember(Value = "sensorPowerSavingScheduleSuccessEvent")]
	SensorPowerSavingScheduleSuccessEvent,


	/// <summary>
	/// Sensor Power Saving Schedule Failure Event
	/// </summary>
	[EnumMember(Value = "sensorPowerSavingScheduleFailureEvent")]
	SensorPowerSavingScheduleFailureEvent,
}
