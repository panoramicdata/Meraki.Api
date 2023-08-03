namespace Meraki.Api.Data;

/// <summary>
/// Concentration
/// </summary>
[DataContract]
public class SensorMetricConcentration
{
	///<summary>
	/// Concentration
	/// </summary>
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }
}