using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Mqtt Broker Info
	/// </summary>
	[DataContract]
	public class NetworkMqttBroker
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Host
		/// </summary>
		[DataMember(Name = "host")]
		public string Host { get; set; } = string.Empty;

		/// <summary>
		/// Port
		/// </summary>
		[DataMember(Name = "port")]
		public int Port { get; set; } = 0;
	}
}
