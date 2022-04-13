namespace Meraki.Api.Data;

/// <summary>
/// Sets min bitrate (Mbps) of this SSID. Can be one of '1', '2', '5.5', '6', '9', '11', '12', '18', '24', '36', '48' or '54'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MinBitrate
{
	[EnumMember(Value = "1")]
	OneMbps,

	[EnumMember(Value = "2")]
	TwoMbps,

	[EnumMember(Value = "5.5")]
	FivePointFiveMbps,

	[EnumMember(Value = "6")]
	SixMbps,

	[EnumMember(Value = "9")]
	NineMbps,

	[EnumMember(Value = "11")]
	ElevenMbps,

	[EnumMember(Value = "12")]
	TwelveMbps,

	[EnumMember(Value = "18")]
	EighteenMbps,

	[EnumMember(Value = "24")]
	TwentyFourMbps,

	[EnumMember(Value = "36")]
	ThirtySixMbps,

	[EnumMember(Value = "48")]
	FourtyEightMbps,

	[EnumMember(Value = "54")]
	FiftyFourMbps
}