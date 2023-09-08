namespace Meraki.Api.Data;

/// <summary>
/// Choice between 'dual', '2.4ghz' or '5ghz'. Defaults to dual.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BandOperationMode
{
	/// <summary>
	/// Enum Dual for "dual"
	/// </summary>
	[EnumMember(Value = "dual")]
	Dual,

	/// <summary>
	/// Enum _24ghz for "2.4ghz"
	/// </summary>
	[EnumMember(Value = "2.4ghz")]
	TwoPointFourGHz,

	/// <summary>
	/// Enum _5ghz for "5ghz"
	/// </summary>
	[EnumMember(Value = "5ghz")]
	FiveGHz,

	/// <summary>
	/// Enum multi (undocumented 2023-07-06)
	/// </summary>
	[EnumMember(Value = "multi")]
	Multi
}
