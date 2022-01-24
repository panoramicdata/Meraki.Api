namespace Meraki.Api.Data;

/// <summary>
/// A list of Bonjour services. At least one service must be specified.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BonjourService
{
	/// <summary>
	/// Enum AllServices for "All Services"
	/// </summary>
	[EnumMember(Value = "All Services")]
	AllServices,

	/// <summary>
	/// Enum AirPlay for "AirPlay"
	/// </summary>
	[EnumMember(Value = "AirPlay")]
	AirPlay,

	/// <summary>
	/// Enum AFP for "AFP"
	/// </summary>
	[EnumMember(Value = "AFP")]
	AFP,

	/// <summary>
	/// Enum BitTorrent for "All Services"
	/// </summary>
	[EnumMember(Value = "BitTorrent")]
	BitTorrent,

	/// <summary>
	/// Enum FTP for "FTP"
	/// </summary>
	[EnumMember(Value = "FTP")]
	FTP,

	/// <summary>
	/// Enum iChat for "iChat"
	/// </summary>
	[EnumMember(Value = "iChat")]
	IChat,

	/// <summary>
	/// Enum iTunes for "iTunes"
	/// </summary>
	[EnumMember(Value = "iTunes")]
	iTunes,

	/// <summary>
	/// Enum Printers for "Printers"
	/// </summary>
	[EnumMember(Value = "Printers")]
	Printers,

	/// <summary>
	/// Enum Samba for "Samba"
	/// </summary>
	[EnumMember(Value = "Samba")]
	Samba,

	/// <summary>
	/// Enum Scanners for "Scanners"
	/// </summary>
	[EnumMember(Value = "Scanners")]
	Scanners,

	/// <summary>
	/// Enum SSH for "SSH"
	/// </summary>
	[EnumMember(Value = "SSH")]
	SSH
}