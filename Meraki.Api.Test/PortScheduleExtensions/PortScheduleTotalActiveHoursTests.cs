namespace Meraki.Api.Test.PortScheduleExtensions;
public class PortScheduleTotalActiveHoursTests
{
	[Fact]
	public void TotalActiveHoursTest()
	{
		var portSchedule = new PortSchedule
		{
			Monday = new DaySchedule
			{
				Active = true,
				From = "00:00",
				To = "24:00"
			},
			Tuesday = new DaySchedule
			{
				Active = true,
				From = "00:00",
				To = "24:00"
			},
			Wednesday = new DaySchedule
			{
				Active = true,
				From = "00:00",
				To = "24:00"
			},
			Thursday = new DaySchedule
			{
				Active = true,
				From = "00:00",
				To = "24:00"
			},
			Friday = new DaySchedule
			{
				Active = true,
				From = "00:00",
				To = "24:00"
			},
			Saturday = new DaySchedule
			{
				Active = true,
				From = "00:00",
				To = "24:00"
			},
			Sunday = new DaySchedule
			{
				Active = true,
				From = "00:00",
				To = "24:00"
			}
		};
		var totalActiveHours = portSchedule.TotalActiveHours();
		Assert.Equal(168, totalActiveHours);
	}

	[Fact]
	public void Check9To5Test()
	{
		var portSchedule = new PortSchedule
		{
			Monday = new DaySchedule
			{
				Active = true,
				From = "09:00",
				To = "17:00"
			},
			Tuesday = new DaySchedule
			{
				Active = true,
				From = "09:00",
				To = "17:00"
			},
			Wednesday = new DaySchedule
			{
				Active = true,
				From = "09:00",
				To = "17:00"
			},
			Thursday = new DaySchedule
			{
				Active = true,
				From = "09:00",
				To = "17:00"
			},
			Friday = new DaySchedule
			{
				Active = true,
				From = "09:00",
				To = "17:00"
			},
			Saturday = new DaySchedule
			{
				Active = true,
				From = "09:00",
				To = "17:00"
			},
			Sunday = new DaySchedule
			{
				Active = true,
				From = "09:00",
				To = "17:00"
			}
		};
		var totalActiveHours = portSchedule.TotalActiveHours();
		Assert.Equal(56, totalActiveHours);
	}
}
