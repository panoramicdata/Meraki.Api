using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Mqtt Broker Info
	/// </summary>
	[DataContract]
	public class MqttBrokerCreateUpdateRequest : NamedIdentifiedItem
	{
		/// <summary>
		/// Host name/IP address where the MQTT broker runs.
		/// </summary>
		[DataMember(Name = "host")]
		public string Host { get; set; } = string.Empty;

		/// <summary>
		/// Host port though which the MQTT broker can be reached.
		/// </summary>
		[DataMember(Name = "port")]
		public int Port { get; set; }

		/// <summary>
		/// Authentication settings of the MQTT broker
		/// </summary>
		[DataMember(Name = "authentication")]
		public MqttAuthentication Authentication { get; set; } = new();

		/// <summary>
		/// Security settings of the MQTT broker.
		/// </summary>
		[DataMember(Name = "security")]
		public MqttSecurityCreateUpdateRequest Security { get; set; } = new();
	}
}
