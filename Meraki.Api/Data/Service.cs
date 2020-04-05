using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Defines Service
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Service
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
		/// Enum BitTorrent for "BitTorrent"
		/// </summary>
		[EnumMember(Value = "BitTorrent")]
		BitTorrent,

		/// <summary>
		/// Enum FTP for "FTP"
		/// </summary>
		[EnumMember(Value = "FTP")]
		FTP,

		/// <summary>
		/// Enum IChat for "iChat"
		/// </summary>
		[EnumMember(Value = "iChat")]
		IChat,

		/// <summary>
		/// Enum ITunes for "iTunes"
		/// </summary>
		[EnumMember(Value = "iTunes")]
		ITunes,

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
}
