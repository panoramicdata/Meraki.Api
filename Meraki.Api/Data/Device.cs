using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A device
	/// </summary>
	[DataContract]
	public class Device : NamedItem
	{
		/// <summary>
		/// OrganizationId
		/// </summary>
		[DataMember(Name = "organizationId")]
		public string OrganizationId { get; set; } = null!;

		/// <summary>
		/// Latitude
		/// </summary>
		[DataMember(Name = "lat")]
		public float Latitude { get; set; }

		/// <summary>
		/// Longitude
		/// </summary>
		[DataMember(Name = "lng")]
		public float Longitude { get; set; }

		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public string Address { get; set; } = string.Empty;

		/// <summary>
		/// Notes
		/// </summary>
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public string Tags { get; set; } = string.Empty;

		/// <summary>
		/// Network Id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Model
		/// </summary>
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;

		/// <summary>
		/// Mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// LanIp
		/// </summary>
		[DataMember(Name = "lanIp")]
		public string LanIp { get; set; } = string.Empty;

		/// <summary>
		/// beaconIdParams
		/// </summary>
		[DataMember(Name = "beaconIdParams")]
		public BeaconIdParams BeaconIdParams { get; set; } = new BeaconIdParams();

		/// <summary>
		/// firmware
		/// </summary>
		[DataMember(Name = "firmware")]
		public string Firmware { get; set; } = string.Empty;
	}
}