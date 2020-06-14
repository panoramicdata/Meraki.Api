using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An organization license
	/// </summary>
	[DataContract]
	public class OrganizationLicense : IdentifiedItem
	{
		/// <summary>
		/// LicenseType
		/// </summary>
		[DataMember(Name = "licenseType")]
		public string LicenseType { get; set; } = string.Empty;

		/// <summary>
		/// LicenseKey
		/// </summary>
		[DataMember(Name = "licenseKey")]
		public string LicenseKey { get; set; } = string.Empty;

		/// <summary>
		/// OrderNumber
		/// </summary>
		[DataMember(Name = "orderNumber")]
		public string OrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// DeviceSerial
		/// </summary>
		[DataMember(Name = "deviceSerial")]
		public string DeviceSerial { get; set; } = string.Empty;

		/// <summary>
		/// NetworkId
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// State
		/// </summary>
		[DataMember(Name = "state")]
		public string State { get; set; } = string.Empty;

		/// <summary>
		/// SeatCount
		/// </summary>
		[DataMember(Name = "seatCount")]
		public int? SeatCount { get; set; }

		/// <summary>
		/// TotalDurationInDays
		/// </summary>
		[DataMember(Name = "totalDurationInDays")]
		public int TotalDurationInDays { get; set; }

		/// <summary>
		/// DurationInDays
		/// </summary>
		[DataMember(Name = "durationInDays")]
		public int DurationInDays { get; set; }

		/// <summary>
		/// PermanentlyQueuedLicenses
		/// </summary>
		[DataMember(Name = "permanentlyQueuedLicenses")]
		public List<Dictionary<string, string>> PermanentlyQueuedLicenses { get; set; } = new List<Dictionary<string, string>>();

		/// <summary>
		/// ClaimDate
		/// </summary>
		[DataMember(Name = "claimDate")]
		public string ClaimDate { get; set; } = string.Empty;

		/// <summary>
		/// ActivationDate
		/// </summary>
		[DataMember(Name = "activationDate")]
		public string ActivationDate { get; set; } = string.Empty;

		/// <summary>
		/// ExpirationDate
		/// </summary>
		[DataMember(Name = "expirationDate")]
		public string ExpirationDate { get; set; } = string.Empty;
	}
}