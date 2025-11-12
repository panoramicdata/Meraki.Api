namespace Meraki.Api;

/// <summary>
/// Sensor metrics
/// </summary>
public partial class MerakiClient
{
	/// <summary>
	/// Gets sensor reading ranges and thresholds for various sensor metrics, consistent with the Meraki Dashboard UI
	/// </summary>
	// The following data ensures consistency between SensorMetrics and the Meraki Dashboard UI for the Sensor Readings page.
	public static Dictionary<SensorMetrics, List<SensorRange>> SensorRanges
		=> new()
	{
		{
			SensorMetrics.Temperature,
			new List<SensorRange>
			{
				new() {
					Name = "Inadequate",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(62),
				},
				new() {
					Name = "Poor",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(64),
				},
				new() {
					Name = "Fair",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(66),
				},
				new() {
					Name = "Good",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(68),
				},
				new() {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = FarenheitToCelsius(76),
				},
				new() {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = FarenheitToCelsius(78),
				},
				new() {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = FarenheitToCelsius(80),
				},
				new() {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = FarenheitToCelsius(82),
				},
				new() {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Humidity,
			new List<SensorRange>
			{
				new() {
					Name = "Inadequate",
					Type = SensorRangeType.Low,
					Max = 10,
				},
				new() {
					Name = "Poor",
					Type = SensorRangeType.Low,
					Max = 20,
				},
				new() {
					Name = "Fair",
					Type = SensorRangeType.Low,
					Max = 30,
				},
				new() {
					Name = "Good",
					Type = SensorRangeType.Low,
					Max = 40,
				},
				new() {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 60,
				},
				new() {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 70,
				},
				new() {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 80,
				},
				new() {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 90,
				},
				new() {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Tvoc,
			new List<SensorRange>
			{
				new() {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 300,
				},
				new() {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 1000,
				},
				new() {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 3000,
				},
				new() {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 10000,
				},
				new() {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Pm25,
			new List<SensorRange>
			{
				new() {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 23,
				},
				new() {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 41,
				},
				new() {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 53,
				},
				new() {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 64,
				},
				new() {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Noise,
			new List<SensorRange>
			{
				new() {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 50,
				},
				new() {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 60,
				},
				new() {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 70,
				},
				new() {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 80,
				},
				new() {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		}
	};

	private static double? FarenheitToCelsius(int farenheit)
		=> (farenheit - 32) * 5 / 9;
}