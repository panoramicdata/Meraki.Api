namespace Meraki.Api;

/// <summary>
/// Sensor metrics
/// </summary>
public partial class MerakiClient
{
	// The following data ensures consistency between SensorMetrics and the Meraki Dashboard UI for the Sensor Readings page.
	public Dictionary<SensorMetrics, List<SensorRange>> SensorRanges => new()
	{
		{
			SensorMetrics.Temperature,
			new List<SensorRange>
			{
				new SensorRange {
					Name = "Inadequate",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(62),
				},
				new SensorRange {
					Name = "Poor",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(64),
				},
				new SensorRange {
					Name = "Fair",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(66),
				},
				new SensorRange {
					Name = "Good",
					Type = SensorRangeType.Low,
					Max = FarenheitToCelsius(68),
				},
				new SensorRange {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = FarenheitToCelsius(76),
				},
				new SensorRange {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = FarenheitToCelsius(78),
				},
				new SensorRange {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = FarenheitToCelsius(80),
				},
				new SensorRange {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = FarenheitToCelsius(82),
				},
				new SensorRange {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Humidity,
			new List<SensorRange>
			{
				new SensorRange {
					Name = "Inadequate",
					Type = SensorRangeType.Low,
					Max = 10,
				},
				new SensorRange {
					Name = "Poor",
					Type = SensorRangeType.Low,
					Max = 20,
				},
				new SensorRange {
					Name = "Fair",
					Type = SensorRangeType.Low,
					Max = 30,
				},
				new SensorRange {
					Name = "Good",
					Type = SensorRangeType.Low,
					Max = 40,
				},
				new SensorRange {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 60,
				},
				new SensorRange {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 70,
				},
				new SensorRange {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 80,
				},
				new SensorRange {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 90,
				},
				new SensorRange {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Tvoc,
			new List<SensorRange>
			{
				new SensorRange {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 300,
				},
				new SensorRange {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 1000,
				},
				new SensorRange {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 3000,
				},
				new SensorRange {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 10000,
				},
				new SensorRange {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Pm25,
			new List<SensorRange>
			{
				new SensorRange {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 23,
				},
				new SensorRange {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 41,
				},
				new SensorRange {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 53,
				},
				new SensorRange {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 64,
				},
				new SensorRange {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		},
		{
			SensorMetrics.Noise,
			new List<SensorRange>
			{
				new SensorRange {
					Name = "Excellent",
					Type = SensorRangeType.Ok,
					Max = 50,
				},
				new SensorRange {
					Name = "Good",
					Type = SensorRangeType.High,
					Max = 60,
				},
				new SensorRange {
					Name = "Fair",
					Type = SensorRangeType.High,
					Max = 70,
				},
				new SensorRange {
					Name = "Poor",
					Type = SensorRangeType.High,
					Max = 80,
				},
				new SensorRange {
					Name = "Inadequate",
					Type = SensorRangeType.High,
				}
			}
		}
	};

	private double? FarenheitToCelsius(int farenheit) => (farenheit - 32) * 5 / 9;
}