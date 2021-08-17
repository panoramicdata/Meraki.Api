using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Events
	/// </summary>
	[DataContract]
	public class Events
	{
		/// <summary>
		/// Occurred at
		/// </summary>
		[DataMember(Name = "occurredAt")]
		public string OccurredAt { get; set; } = string.Empty;

		/// <summary>
		/// Network id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Client id
		/// </summary>
		[DataMember(Name = "clientId")]
		public string ClientId { get; set; } = string.Empty;

		/// <summary>
		/// Client description
		/// </summary>
		[DataMember(Name = "clientDescription")]
		public string ClientDescription { get; set; } = string.Empty;

		/// <summary>
		/// Device serial
		/// </summary>
		[DataMember(Name = "deviceSerial")]
		public string DeviceSerial { get; set; } = string.Empty;

		/// <summary>
		/// Device name
		/// </summary>
		[DataMember(Name = "deviceName")]
		public string DeviceName { get; set; } = string.Empty;

		/// <summary>
		/// SSID number
		/// </summary>
		[DataMember(Name = "ssidNumber")]
		public int SsidNumber { get; set; }

		/// <summary>
		/// SSID name
		/// </summary>
		[DataMember(Name = "ssidName")]
		public string SsidName { get; set; } = string.Empty;

		/// <summary>
		/// Event data
		/// </summary>
		[DataMember(Name = "eventData")]
		public EventData EventData { get; set; } = new();
	}
}
