using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An organization device
	/// </summary>
	[DataContract]
	public class OrganizationDevice : NamedItem
	{
		/// <summary>
		/// name
		/// </summary>
		[DataMember(Name = "name")]
		new public string Name { get; set; } = string.Empty;

		/// <summary>
		/// serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// networkId
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// model
		/// </summary>
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;

		/// <summary>
		/// address
		/// </summary>
		[DataMember(Name = "address")]
		public string Address { get; set; } = string.Empty;

		/// <summary>
		/// lat
		/// </summary>
		[DataMember(Name = "lat")]
		public double Lat { get; set; }

		/// <summary>
		/// lng
		/// </summary>
		[DataMember(Name = "lng")]
		public double Lng { get; set; }

		/// <summary>
		/// notes
		/// </summary>
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// tags
		/// </summary>
		[DataMember(Name = "tags")]
		public string Tags { get; set; } = string.Empty;

		/// <summary>
		/// lanIp
		/// </summary>
		[DataMember(Name = "lanIp")]
		public string LanIp { get; set; } = string.Empty;

		/// <summary>
		/// configurationUpdatedAt
		/// </summary>
		[DataMember(Name = "configurationUpdatedAt")]
		public string ConfigurationUpdatedAt { get; set; } = string.Empty;

		/// <summary>
		/// firmware
		/// </summary>
		[DataMember(Name = "firmware")]
		public string Firmware { get; set; } = string.Empty;

		/// <summary>
		/// url
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}