using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The schedule for switch port scheduling. Schedules are applied to days of the week.     When it&#39;s empty, default schedule with all days of a week are configured.     Any unspecified day in the schedule is added as a default schedule configuration of the day.
	/// </summary>
	[DataContract]
	public class PortSchedule
	{
		/// <summary>
		/// Gets or Sets Monday
		/// </summary>
		[DataMember(Name = "monday")]
		public DayPortSchedule? Monday { get; set; }

		/// <summary>
		/// Gets or Sets Tuesday
		/// </summary>
		[DataMember(Name = "tuesday")]
		public DayPortSchedule? Tuesday { get; set; }

		/// <summary>
		/// Gets or Sets Wednesday
		/// </summary>
		[DataMember(Name = "wednesday")]
		public DayPortSchedule? Wednesday { get; set; }

		/// <summary>
		/// Gets or Sets Thursday
		/// </summary>
		[DataMember(Name = "thursday")]
		public DayPortSchedule? Thursday { get; set; }

		/// <summary>
		/// Gets or Sets Friday
		/// </summary>
		[DataMember(Name = "friday")]
		public DayPortSchedule? Friday { get; set; }

		/// <summary>
		/// Gets or Sets Saturday
		/// </summary>
		[DataMember(Name = "saturday")]
		public DayPortSchedule? Saturday { get; set; }

		/// <summary>
		/// Gets or Sets Sunday
		/// </summary>
		[DataMember(Name = "sunday")]
		public DayPortSchedule? Sunday { get; set; }
	}
}
