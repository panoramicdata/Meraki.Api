using System.Runtime.Serialization;

namespace Meraki.Api.Test.Config
{
	/// <summary>
	/// Test configuration
	/// </summary>
	[DataContract]
	public class Configuration
	{
		/// <summary>
		/// Meraki client options
		/// </summary>
		[DataMember(Name = "MerakiClientOptions")]
		public MerakiClientOptions MerakiClientOptions { get; set; } = null!;

		/// <summary>
		/// Test Organization Id
		/// </summary>
		[DataMember(Name = "TestOrganizationId")]
		public long TestOrganizationId { get; set; }

		/// <summary>
		/// Test Device Serial
		/// </summary>
		[DataMember(Name = "TestDeviceSerial")]
		public string TestDeviceSerial { get; set; } = string.Empty;
	}
}
