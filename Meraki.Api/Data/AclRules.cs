using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rules
	/// </summary>
	[DataContract]
	public class AclRules
	{
		/// <summary>
		/// Policy
		/// </summary>
		[DataMember(Name = "policy")]
		public string Policy { get; set; } = string.Empty;

		/// <summary>
		/// Protocol
		/// </summary>
		[DataMember(Name = "protocol")]
		public string Protocol { get; set; } = string.Empty;

		/// <summary>
		/// Src port
		/// </summary>
		[DataMember(Name = "srcPort")]
		public string SrcPort { get; set; } = string.Empty;

		/// <summary>
		/// Dst port
		/// </summary>
		[DataMember(Name = "dstPort")]
		public string DstPort { get; set; } = string.Empty;
	}
}
