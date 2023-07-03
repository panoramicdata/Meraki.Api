namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for TVOC (total volatile organic compounds)
/// Total Volatile Organic Compounds (TVOC) measures the total amount of VOC's in the area. VOC's include a variety of chemicals, such as paints, aerosol sprays, cleaning solutions, pesticides, and automotive products. They can also include chemicals from smoking electronic cigarettes, also known as vaping. High TVOC levels can negatively affect comfort, health, and productivity. Symptoms associated with high TVOC's include sinus irritation, headaches, nausea, and damage to the liver, kidneys, and nervous system. Some VOC's are also known to cause cancer in humans.
/// On first boot, the TVOC sensor undergoes a refinement period of about 48 hours, where it calibrates the current environment as baseline. MT14's TVOC accuracy varies according to environmental conditions; MT14 readings become more accurate over time if TVOC levels are kept low for the majority of the time.
/// </summary>
[DataContract]
public class SensorMetricTvoc
{
	/// <summary>
	/// Total volatile organic compounds in parts per billion
	/// </summary>
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }
}