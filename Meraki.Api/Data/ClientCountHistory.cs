using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Client count history
	/// </summary>
	[DataContract]
	public class ClientCountHistory
	{
		/// <summary>
		/// startTs
		/// </summary>
		[DataMember(Name = "startTs")]
		public string StartTs { get; set; } = string.Empty;

		/// <summary>
		/// endTs
		/// </summary>
		[DataMember(Name = "endTs")]
		public string EndTs { get; set; } = string.Empty;

		/// <summary>
		/// Client count
		/// </summary>
		[DataMember(Name = "clientCount")]
		public int ClientCount { get; set; } = 0;
	}
}
