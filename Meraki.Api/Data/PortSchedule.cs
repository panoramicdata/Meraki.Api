using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The schedule for switch port scheduling. Schedules are applied to days of the week.     When it&#39;s empty, default schedule with all days of a week are configured.     Any unspecified day in the schedule is added as a default schedule configuration of the day.
	/// </summary>
	[DataContract]
	public partial class PortSchedule
	{
		/// <summary>
		/// Gets or Sets Monday
		/// </summary>
		[DataMember(Name = "monday", EmitDefaultValue = false)]
		public DayPortSchedule Monday { get; set; } = new();

		/// <summary>
		/// Gets or Sets Tuesday
		/// </summary>
		[DataMember(Name = "tuesday", EmitDefaultValue = false)]
		public DayPortSchedule Tuesday { get; set; } = new();

		/// <summary>
		/// Gets or Sets Wednesday
		/// </summary>
		[DataMember(Name = "wednesday", EmitDefaultValue = false)]
		public DayPortSchedule Wednesday { get; set; } = new();

		/// <summary>
		/// Gets or Sets Thursday
		/// </summary>
		[DataMember(Name = "thursday", EmitDefaultValue = false)]
		public DayPortSchedule Thursday { get; set; } = new();

		/// <summary>
		/// Gets or Sets Friday
		/// </summary>
		[DataMember(Name = "friday", EmitDefaultValue = false)]
		public DayPortSchedule Friday { get; set; } = new();

		/// <summary>
		/// Gets or Sets Saturday
		/// </summary>
		[DataMember(Name = "saturday", EmitDefaultValue = false)]
		public DayPortSchedule Saturday { get; set; } = new();

		/// <summary>
		/// Gets or Sets Sunday
		/// </summary>
		[DataMember(Name = "sunday", EmitDefaultValue = false)]
		public DayPortSchedule Sunday { get; set; } = new();
	}
}
