using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Inventory devices
	/// </summary>
	[DataContract]
	public class InventoryDevices
	{
		/// <summary>
		/// Mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// Serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Model
		/// </summary>
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;

		/// <summary>
		/// Network ID
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Order number
		/// </summary>
		[DataMember(Name = "orderNumber")]
		public string OrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// Claimed at
		/// </summary>
		[DataMember(Name = "claimedAt")]
		public string ClaimedAt { get; set; } = string.Empty;

		/// <summary>
		/// Licence expiration date
		/// </summary>
		[DataMember(Name = "licenceExpirationDate")]
		public string LicenceExpirationDate { get; set; } = string.Empty;
	}
}
