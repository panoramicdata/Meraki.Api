using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Packet
	/// </summary>
	[DataContract]
	public class Packets
	{
		/// <summary>
		/// Desc
		/// </summary>
		[DataMember(Name = "desc")]
		public string Desc { get; set; } = string.Empty;

		/// <summary>
		/// Total
		/// </summary>
		[DataMember(Name = "total")]
		public int Total { get; set; }

		/// <summary>
		/// Sent
		/// </summary>
		[DataMember(Name = "sent")]
		public int Sent { get; set; }

		/// <summary>
		/// Received
		/// </summary>
		[DataMember(Name = "recv")]
		public int Recv { get; set; }

		/// <summary>
		/// Rate per second
		/// </summary>
		[DataMember(Name = "ratePerSec")]
		public RatePerSec RatePerSec { get; set; } = new();
	}
}
