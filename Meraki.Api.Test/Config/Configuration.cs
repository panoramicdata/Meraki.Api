using Meraki.Api.Exceptions;
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
		public string TestOrganizationId { get; set; } = string.Empty;

		/// <summary>
		/// Test Device Serial
		/// </summary>
		[DataMember(Name = "TestDeviceSerial")]
		public string TestDeviceSerial { get; set; } = string.Empty;

		/// <summary>
		/// Test Camera Serial
		/// </summary>
		[DataMember(Name = "TestCameraSerial")]
		public string TestCameraSerial { get; set; } = string.Empty;

		/// <summary>
		/// Test Camera Network Name
		/// </summary>
		[DataMember(Name = "TestCameraNetworkId")]
		public string TestCameraNetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Test Network ID
		/// </summary>
		[DataMember(Name = "TestNetworkId")]
		public string TestNetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Test MAC (Client ID)
		/// </summary>
		[DataMember(Name = "TestMac")]
		public string TestMac { get; set; } = string.Empty;

		public void Validate()
		{
			// MerakiClientOptions should be present
			if (MerakiClientOptions is null)
			{
				throw new ConfigurationException($"Missing {nameof(MerakiClientOptions)}");
			}
			MerakiClientOptions.Validate();

			if (string.IsNullOrWhiteSpace(TestOrganizationId))
			{
				throw new ConfigurationException($"Missing {nameof(TestOrganizationId)}");
			}

			if (string.IsNullOrWhiteSpace(TestDeviceSerial))
			{
				throw new ConfigurationException($"Missing {nameof(TestDeviceSerial)}");
			}

			if (string.IsNullOrWhiteSpace(TestCameraSerial))
			{
				throw new ConfigurationException($"Missing {nameof(TestCameraSerial)}");
			}

			if (string.IsNullOrWhiteSpace(TestCameraNetworkId))
			{
				throw new ConfigurationException($"Missing {nameof(TestCameraNetworkId)}");
			}

			if (string.IsNullOrWhiteSpace(TestNetworkId))
			{
				throw new ConfigurationException($"Missing {nameof(TestNetworkId)}");
			}

			if (string.IsNullOrWhiteSpace(TestMac))
			{
				throw new ConfigurationException($"Missing {nameof(TestMac)}");
			}
		}
	}
}
