using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings
	/// </summary>
	[DataContract]
	public class RadioGhzSettings
	{
		/// <summary>
		/// Channel
		/// </summary>
		[DataMember(Name = "channel")]
		public int? Channel { get; set; }

		/// <summary>
		/// Channel width
		/// </summary>
		[DataMember(Name = "channelWidth")]
		public int? ChannelWidth { get; set; }

		/// <summary>
		/// Target power
		/// </summary>
		[DataMember(Name = "targetPower")]
		public int? TargetPower { get; set; }
	}
}
