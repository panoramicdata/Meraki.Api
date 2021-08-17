using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Warm spare
	/// </summary>
	[DataContract]
	public class WarmSpare
	{
		/// <summary>
		/// Enabled
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Primary serial
		/// </summary>
		[DataMember(Name = "primarySerial")]
		public string PrimarySerial { get; set; } = string.Empty;

		/// <summary>
		/// Spare serial
		/// </summary>
		[DataMember(Name = "spareSerial")]
		public string SpareSerial { get; set; } = string.Empty;

		/// <summary>
		/// Uplink mode
		/// </summary>
		[DataMember(Name = "uplinkMode")]
		public string UplinkMode { get; set; } = string.Empty;

		/// <summary>
		/// WAN 1
		/// </summary>
		[DataMember(Name = "wan1")]
		public Wan Wan1 { get; set; } = new();

		/// <summary>
		/// WAN 2
		/// </summary>
		[DataMember(Name = "wan2")]
		public Wan Wan2 { get; set; } = new();
	}
}
