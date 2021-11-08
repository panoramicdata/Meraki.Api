using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Camera sense
	/// </summary>
	[DataContract]
	public class CameraSense
	{
		/// <summary>
		/// Boolean indicating if sense(license) is enabled(true) or disabled(false) on the camera
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "senseEnabled")]
		public bool SenseEnabled { get; set; }

		/// <summary>
		/// The details of the audio detection config
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "audioDetection")]
		public AudioDetection AudioDetection { get; set; } = new();

		/// <summary>
		/// The ID of the MQTT broker to be enabled on the camera. A value of null will disable MQTT on the camera
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "mqttBrokerId")]
		public string MqttBrokerId { get; set; } = string.Empty;

		/// <summary>
		/// MQTT topics
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "mqttTopics")]
		public List<string> MqttTopics { get; set; } = new();
	}
}
