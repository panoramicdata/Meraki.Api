using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Cert
	/// </summary>
	[DataContract]
	public class DeviceCert
	{
		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Not valid after
		/// </summary>
		[DataMember(Name = "notValidAfter")]
		public string NotValidAfter { get; set; } = string.Empty;

		/// <summary>
		/// Not valid before
		/// </summary>
		[DataMember(Name = "notValidBefore")]
		public string NotValidBefore { get; set; } = string.Empty;

		/// <summary>
		/// Cert pem
		/// </summary>
		[DataMember(Name = "certPem")]
		public string CertPem { get; set; } = string.Empty;

		/// <summary>
		/// Device id
		/// </summary>
		[DataMember(Name = "deviceId")]
		public string DeviceId { get; set; } = string.Empty;

		/// <summary>
		/// Issuer
		/// </summary>
		[DataMember(Name = "issuer")]
		public string Issuer { get; set; } = string.Empty;

		/// <summary>
		/// Subject
		/// </summary>
		[DataMember(Name = "subject")]
		public string Subject { get; set; } = string.Empty;

		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;
	}
}
