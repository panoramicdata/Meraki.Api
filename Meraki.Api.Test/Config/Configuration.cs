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
		public int TestOrganizationId { get; set; }

		/// <summary>
		/// Test Network Id
		/// </summary>
		[DataMember(Name = "TestNetworkId")]
		public string TestNetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Test Device Serial
		/// </summary>
		[DataMember(Name = "TestDeviceSerial")]
		public string TestDeviceSerial { get; set; } = string.Empty;
	}
}
