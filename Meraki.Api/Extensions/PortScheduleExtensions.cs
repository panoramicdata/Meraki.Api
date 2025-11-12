using System.Globalization;

namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for Port Schedule
/// </summary>
public static class PortScheduleExtensions
{
	/// <summary>
	/// Calculates the total active hours across all days in a week for a port schedule
	/// </summary>
	/// <param name="portSchedule">The port schedule</param>
	/// <returns>The total active hours for the week</returns>
	public static double TotalActiveHours(this PortSchedule portSchedule)
		=> portSchedule.Monday!.TotalActiveHours() +
			portSchedule.Tuesday!.TotalActiveHours() +
			portSchedule.Wednesday!.TotalActiveHours() +
			portSchedule.Thursday!.TotalActiveHours() +
			portSchedule.Friday!.TotalActiveHours() +
			portSchedule.Saturday!.TotalActiveHours() +
			portSchedule.Sunday!.TotalActiveHours();

	/// <summary>
	/// Calculates the total active hours for a single day schedule
	/// </summary>
	/// <param name="daySchedule">The day schedule</param>
	/// <returns>The total active hours for the day</returns>
	public static double TotalActiveHours(this DaySchedule daySchedule)
		=> daySchedule.Active
			? GetTotalHours(daySchedule.To) - GetTotalHours(daySchedule.From)
			: 24 - (GetTotalHours(daySchedule.To) - GetTotalHours(daySchedule.From));

	private static double GetTotalHours(string timeString)
		=> timeString == "24:00" ? 24 : TimeSpan.Parse(timeString, CultureInfo.InvariantCulture).TotalHours;
}
