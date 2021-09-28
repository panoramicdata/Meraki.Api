using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The schedule for the group policy. Schedules are applied to days of the week.
	/// </summary>
	[DataContract]
	public class Scheduling
	{
		/// <summary>
		/// Whether scheduling is enabled (true) or disabled (false). Defaults to false. If true, the schedule objects for each day of the week (monday - sunday) are parsed.
		/// </summary>
		/// <value>Whether scheduling is enabled (true) or disabled (false). Defaults to false. If true, the schedule objects for each day of the week (monday - sunday) are parsed.</value>
		[DataMember(Name = "enabled")]
		public bool? Enabled { get; set; }

		/// <summary>
		/// Gets or Sets Monday
		/// </summary>
		[DataMember(Name = "monday")]
		public DayPortSchedule Monday { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Tuesday
		/// </summary>
		[DataMember(Name = "tuesday")]
		public DayPortSchedule Tuesday { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Wednesday
		/// </summary>
		[DataMember(Name = "wednesday")]
		public DayPortSchedule Wednesday { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Thursday
		/// </summary>
		[DataMember(Name = "thursday")]
		public DayPortSchedule Thursday { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Friday
		/// </summary>
		[DataMember(Name = "friday")]
		public DayPortSchedule Friday { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Saturday
		/// </summary>
		[DataMember(Name = "saturday")]
		public DayPortSchedule Saturday { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Sunday
		/// </summary>
		[DataMember(Name = "sunday")]
		public DayPortSchedule Sunday { get; set; } = null!;
	}
}
