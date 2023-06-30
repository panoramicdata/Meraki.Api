namespace Meraki.Api.Data;

/// <summary>
/// Sensor Mqtt Broker
/// </summary>
[DataContract]
public class SensorMqttBrokerUpdate
{
	/// <summary>
	/// Specifies whether the broker is enabled for sensor data. Currently, only a single broker may be enabled for sensor data.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}