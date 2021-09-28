using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Usage history
	/// </summary>
	[DataContract]
	public class SubclassUsageHistory
	{
		/// <summary>
		/// Ts
		/// </summary>
		[DataMember(Name = "ts")]
		public string Ts { get; set; } = string.Empty;

		/// <summary>
		/// Recv
		/// </summary>
		[DataMember(Name = "recv")]
		public int Recv { get; set; }

		/// <summary>
		/// Sent
		/// </summary>
		[DataMember(Name = "sent")]
		public int Sent { get; set; }
	}
}
