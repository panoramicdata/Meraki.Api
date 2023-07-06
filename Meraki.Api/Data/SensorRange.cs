using System.Drawing;

namespace Meraki.Api.Data;

public class SensorRange
{
	public string Name { get; set; } = string.Empty;

	public double? Min { get; set; }

	public double? Max { get; set; }

	public Color Color => Name switch
	{
		"Inadequate" => Color.FromArgb(218, 31, 0),
		"Poor" => Color.FromArgb(255, 145, 0),
		"Fair" => Color.FromArgb(25, 191, 63),
		"Good" => Color.FromArgb(143, 188, 66),
		"Excellent" => Color.FromArgb(64, 185, 64),
		_ => Color.Empty
	};

	public SensorRangeType Type { get; set; } = SensorRangeType.Ok;
}