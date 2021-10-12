using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Mqtt Broker Info
	/// </summary>
	[DataContract]
	public class MqttBroker : NamedIdentifiedItem
	{
		/// <summary>
		/// Host name/IP address where the MQTT broker runs.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "host")]
		public string Host { get; set; } = string.Empty;

		/// <summary>
		/// Host port though which the MQTT broker can be reached.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "port")]
		public int Port { get; set; }

		/// <summary>
		/// Authentication settings of the MQTT broker
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "authentication")]
		public MqttAuthentication Authentication { get; set; } = new();

		/// <summary>
		/// Security settings of the MQTT broker.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "security")]
		public MqttSecurity Security { get; set; } = new();
	}
}
