namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for noise
/// Ambient noise levels affect people's comfort, productivity, and hearing health. High ambient noise can make it difficult to concentrate or communicate with others. If ambient noise exceeds 85 decibels for extended periods of time, it can lead to hearing damage and long-term hearing loss.
/// </summary>
[DataContract]
public class SensorMetricNoise
{
	///<summary>
	/// Noise in decibels
	/// </summary>
	[DataMember(Name = "ambient")]
	public SensorMetricNoiseAmbient Ambient { get; set; } = new();
}