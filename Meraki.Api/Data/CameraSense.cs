using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Camera sense
	/// </summary>
	[DataContract]
	public class CameraSense
	{
		/// <summary>
		/// Sense enabled?
		/// </summary>
		[DataMember(Name = "senseEnabled")]
		public bool SenseEnabled { get; set; }

		/// <summary>
		/// Audio detection
		/// </summary>
		[DataMember(Name = "audioDetection")]
		public AudioDetection AudioDetection { get; set; } = new();

		/// <summary>
		/// MQTT broker id
		/// </summary>
		[DataMember(Name = "mqttBrokerId")]
		public string MqttBrokerId { get; set; } = string.Empty;

		/// <summary>
		/// MQTT topics
		/// </summary>
		[DataMember(Name = "mqttTopics")]
		public List<string> MqttTopics { get; set; } = new();
	}
}
