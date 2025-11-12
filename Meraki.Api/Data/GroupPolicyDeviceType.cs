namespace Meraki.Api.Data;

/// <summary>
/// Group Policy Device Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GroupPolicyDeviceType
{
	[EnumMember(Value = "Android")]
	/// <summary>
	/// Android
	/// </summary>
	Android,

	[EnumMember(Value = "BlackBerry")]
	/// <summary>
	/// Black Berry
	/// </summary>
	BlackBerry,

	[EnumMember(Value = "Chrome OS")]
	/// <summary>
	/// Chrome OS
	/// </summary>
	ChromeOS,

	[EnumMember(Value = "iPad")]
	/// <summary>
	/// I Pad
	/// </summary>
	IPad,

	[EnumMember(Value = "iPhone")]
	/// <summary>
	/// I Phone
	/// </summary>
	IPhone,

	[EnumMember(Value = "iPod")]
	/// <summary>
	/// I Pod
	/// </summary>
	IPod,

	[EnumMember(Value = "Mac OS X")]
	/// <summary>
	/// Mac OSX
	/// </summary>
	MacOSX,

	[EnumMember(Value = "Windows")]
	/// <summary>
	/// Windows
	/// </summary>
	Windows,

	[EnumMember(Value = "Windows Phone")]
	/// <summary>
	/// Windows Phone
	/// </summary>
	WindowsPhone,

	[EnumMember(Value = "B&N Nook")]
	/// <summary>
	/// B And N Nook
	/// </summary>
	BAndNNook,

	[EnumMember(Value = "Other OS")]
	/// <summary>
	/// Other OS
	/// </summary>
	OtherOS
}
