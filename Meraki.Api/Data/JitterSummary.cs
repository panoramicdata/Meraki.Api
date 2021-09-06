using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Jitter summary
	/// </summary>
	[DataContract]
	public class JitterSummary
	{
		/// <summary>
		/// Sender uplink
		/// </summary>
		[DataMember(Name = "senderUplink")]
		public string SenderUplink { get; set; } = string.Empty;

		/// <summary>
		/// Receiver uplink
		/// </summary>
		[DataMember(Name = "receiverUplink")]
		public string ReceiverUplink { get; set; } = string.Empty;

		/// <summary>
		/// Average jitter
		/// </summary>
		[DataMember(Name = "avgJitter")]
		public int AvgJitter { get; set; } = 0;

		/// <summary>
		/// Minimum jitter
		/// </summary>
		[DataMember(Name = "minJitter")]
		public int MinJitter { get; set; } = 0;

		/// <summary>
		/// Maximum jitter
		/// </summary>
		[DataMember(Name = "maxJitter")]
		public int MaxJitter { get; set; } = 0;
	}
}
