using Meraki.Api.Attributes;
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
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "monday")]
		public DaySchedule? Monday { get; set; }

		/// <summary>
		/// Gets or Sets Tuesday
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "tuesday")]
		public DaySchedule? Tuesday { get; set; }

		/// <summary>
		/// Gets or Sets Wednesday
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "wednesday")]
		public DaySchedule? Wednesday { get; set; }

		/// <summary>
		/// Gets or Sets Thursday
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "thursday")]
		public DaySchedule? Thursday { get; set; }

		/// <summary>
		/// Gets or Sets Friday
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "friday")]
		public DaySchedule? Friday { get; set; }

		/// <summary>
		/// Gets or Sets Saturday
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "saturday")]
		public DaySchedule? Saturday { get; set; }

		/// <summary>
		/// Gets or Sets Sunday
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "sunday")]
		public DaySchedule? Sunday { get; set; }
	}
}
