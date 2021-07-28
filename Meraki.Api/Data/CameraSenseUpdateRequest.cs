using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Camera sense update request
	/// </summary>
	[DataContract]
	public class CameraSenseUpdateRequest
	{
		/// <summary>
		/// The ID of the object detection model
		/// </summary>
		[DataMember(Name = "detectionModelId")]
		public string DetectionModelId { get; set; } = string.Empty;

		/// <summary>
		/// The ID of the MQTT broker to be enabled on the camera. A value of null will disable MQTT on the camera
		/// </summary>
		[DataMember(Name = "mqttBrokerId")]
		public string MqttBrokerId { get; set; } = string.Empty;

		/// <summary>
		/// Boolean indicating if sense(license) is enabled(true) or disabled(false) on the camera
		/// </summary>
		[DataMember(Name = "senseEnabled")]
		public bool SenseEnabled { get; set; }

		/// <summary>
		/// The details of the audio detection config.
		/// </summary>
		[DataMember(Name = "audioDetection")]
		public AudioDetection AudioDetection { get; set; } = new();
	}
}
