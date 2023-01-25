namespace Meraki.Api.Test.PortScheduleExtensions;
public class DayScheduleTotalActiveHoursTests
{
	[Fact]
	public void TotalActiveHoursTest()
	{
		var daySchedule = new DaySchedule
		{
			Active = true,
			From = "00:00",
			To = "24:00"
		};
		var totalActiveHours = daySchedule.TotalActiveHours();
		Assert.Equal(24, totalActiveHours);
	}

	[Fact]
	public void Check9To5Test()
	{
		var daySchedule = new DaySchedule
		{
			Active = true,
			From = "09:00",
			To = "17:00"
		};
		var totalActiveHours = daySchedule.TotalActiveHours();
		Assert.Equal(8, totalActiveHours);
	}

	[Fact]
	public void Check9To5InactiveTest()
	{
		var daySchedule = new DaySchedule
		{
			Active = false,
			From = "09:00",
			To = "17:00"
		};
		var totalActiveHours = daySchedule.TotalActiveHours();
		Assert.Equal(16, totalActiveHours);
	}

	[Fact]
	public void CheckInActiveTest()
	{
		var daySchedule = new DaySchedule
		{
			Active = false,
			From = "00:00",
			To = "24:00"
		};
		var totalActiveHours = daySchedule.TotalActiveHours();
		Assert.Equal(0, totalActiveHours);
	}
}
