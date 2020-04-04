using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The schedule for the group policy. Schedules are applied to days of the week.
	/// </summary>
	[DataContract]
	public partial class Scheduling
	{
		/// <summary>
		/// Whether scheduling is enabled (true) or disabled (false). Defaults to false. If true, the schedule objects for each day of the week (monday - sunday) are parsed.
		/// </summary>
		/// <value>Whether scheduling is enabled (true) or disabled (false). Defaults to false. If true, the schedule objects for each day of the week (monday - sunday) are parsed.</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }
		/// <summary>
		/// Gets or Sets Monday
		/// </summary>
		[DataMember(Name = "monday", EmitDefaultValue = false)]
		public DayPortSchedule Monday { get; set; }
		/// <summary>
		/// Gets or Sets Tuesday
		/// </summary>
		[DataMember(Name = "tuesday", EmitDefaultValue = false)]
		public DayPortSchedule Tuesday { get; set; }
		/// <summary>
		/// Gets or Sets Wednesday
		/// </summary>
		[DataMember(Name = "wednesday", EmitDefaultValue = false)]
		public DayPortSchedule Wednesday { get; set; }
		/// <summary>
		/// Gets or Sets Thursday
		/// </summary>
		[DataMember(Name = "thursday", EmitDefaultValue = false)]
		public DayPortSchedule Thursday { get; set; }
		/// <summary>
		/// Gets or Sets Friday
		/// </summary>
		[DataMember(Name = "friday", EmitDefaultValue = false)]
		public DayPortSchedule Friday { get; set; }
		/// <summary>
		/// Gets or Sets Saturday
		/// </summary>
		[DataMember(Name = "saturday", EmitDefaultValue = false)]
		public DayPortSchedule Saturday { get; set; }
		/// <summary>
		/// Gets or Sets Sunday
		/// </summary>
		[DataMember(Name = "sunday", EmitDefaultValue = false)]
		public DayPortSchedule Sunday { get; set; }
	}
}
