namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum GroupPolicyDeviceType
{
	[EnumMember(Value = "Android")]
	Android,

	[EnumMember(Value = "BlackBerry")]
	BlackBerry,

	[EnumMember(Value = "Chrome OS")]
	ChromeOS,

	[EnumMember(Value = "iPad")]
	IPad,

	[EnumMember(Value = "iPhone")]
	IPhone,

	[EnumMember(Value = "iPod")]
	IPod,

	[EnumMember(Value = "Mac OS X")]
	MacOSX,

	[EnumMember(Value = "Windows")]
	Windows,

	[EnumMember(Value = "Windows Phone")]
	WindowsPhone,

	[EnumMember(Value = "B&N Nook")]
	BAndNNook,

	[EnumMember(Value = "Other OS")]
	OtherOS
}