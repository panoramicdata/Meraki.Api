using System.Globalization;

namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for Port Schedule
/// </summary>
public static class PortScheduleExtensions
{
	public static double TotalActiveHours(this PortSchedule portSchedule)
		=> portSchedule.Monday!.TotalActiveHours() +
			portSchedule.Tuesday!.TotalActiveHours() +
			portSchedule.Wednesday!.TotalActiveHours() +
			portSchedule.Thursday!.TotalActiveHours() +
			portSchedule.Friday!.TotalActiveHours() +
			portSchedule.Saturday!.TotalActiveHours() +
			portSchedule.Sunday!.TotalActiveHours();

	public static double TotalActiveHours(this DaySchedule daySchedule)
		=> daySchedule.Active
			? GetTotalHours(daySchedule.To) - GetTotalHours(daySchedule.From)
			: 24 - (GetTotalHours(daySchedule.To) - GetTotalHours(daySchedule.From));

	private static double GetTotalHours(string timeString)
		=> timeString == "24:00" ? 24 : TimeSpan.Parse(timeString, CultureInfo.InvariantCulture).TotalHours;
}
