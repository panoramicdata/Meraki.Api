namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for pm25
/// PM2.5 is particulate matter that is smaller than 2.5 micrometers. These particles are concerning because they are small enough to permeate the mucous membranes in your lungs and can even get into your bloodstream. PM2.5 comes from many sources including automobiles, construction sites, industrial facilities, fires, smokestacks, and cooking fumes along with vaping fumes from e-cigarettes. Prolonged exposure to PM2.5 can lead to respiratory irritation, decreased lung function, heart disease, cancer, and even premature death.
/// </summary>
[DataContract]
public class SensorMetricPm25
{
	///<summary>
	/// PM2.5 in micrograms per cubic meter
	/// </summary>
	public int MicrogramsPerCubicMeter { get; set; }
}