namespace Meraki.Api.Data;

/// <summary>
/// Group Policy Device Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GroupPolicyDeviceType
{
	/// <summary>
	/// Android
	/// </summary>
	[EnumMember(Value = "Android")]
	Android,


	/// <summary>
	/// Black Berry
	/// </summary>
	[EnumMember(Value = "BlackBerry")]
	BlackBerry,


	/// <summary>
	/// Chrome OS
	/// </summary>
	[EnumMember(Value = "Chrome OS")]
	ChromeOS,


	/// <summary>
	/// I Pad
	/// </summary>
	[EnumMember(Value = "iPad")]
	IPad,


	/// <summary>
	/// I Phone
	/// </summary>
	[EnumMember(Value = "iPhone")]
	IPhone,


	/// <summary>
	/// I Pod
	/// </summary>
	[EnumMember(Value = "iPod")]
	IPod,


	/// <summary>
	/// Mac OSX
	/// </summary>
	[EnumMember(Value = "Mac OS X")]
	MacOSX,


	/// <summary>
	/// Windows
	/// </summary>
	[EnumMember(Value = "Windows")]
	Windows,


	/// <summary>
	/// Windows Phone
	/// </summary>
	[EnumMember(Value = "Windows Phone")]
	WindowsPhone,


	/// <summary>
	/// B And N Nook
	/// </summary>
	[EnumMember(Value = "B&N Nook")]
	BAndNNook,


	/// <summary>
	/// Other OS
	/// </summary>
	[EnumMember(Value = "Other OS")]
	OtherOS
}
