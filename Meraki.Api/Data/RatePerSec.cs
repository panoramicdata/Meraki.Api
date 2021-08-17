using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rate per second
	/// </summary>
	[DataContract]
	public class RatePerSec
	{
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
	}
}
