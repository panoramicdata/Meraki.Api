using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Application usage
	/// </summary>
	[DataContract]
	public class SubclassApplicationUsage
	{
		/// <summary>
		/// Application
		/// </summary>
		[DataMember(Name = "application")]
		public string Application { get; set; } = string.Empty;

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
