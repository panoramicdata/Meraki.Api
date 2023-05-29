namespace Meraki.Api.Data;

/// <summary>
/// Sensor Mqtt Broker
/// </summary>
[DataContract]
public class SensorMqttBroker : SensorMqttBrokerUpdate
{
	///<summary>
	/// ID of the MQTT Broker
	/// </summary>
	[ApiKey]
	[DataMember(Name = "mqttBrokerId")]
	public string? MqttBrokerId { get; set; }
}