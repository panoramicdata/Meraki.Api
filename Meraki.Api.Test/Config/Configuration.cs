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
	}
}
