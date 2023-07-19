namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for noise (ambient)
/// </summary>
[DataContract]
public class SensorMetricNoiseAmbient
{
	///<summary>
	/// Noise level in dB
	/// </summary>
	[DataMember(Name = "level")]
	public int Level { get; set; }
}