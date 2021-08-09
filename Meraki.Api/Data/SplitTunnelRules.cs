using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Split tunnel rules
	/// </summary>
	[DataContract]
	public partial class SplitTunnelRules
	{
		/// <summary>
		/// Protocols
		/// </summary>
		[DataMember(Name = "protocols")]
		public string? Protocols { get; set; }

		/// <summary>
		/// Dest cidr
		/// </summary>
		[DataMember(Name = "destCidr")]
		public string DestCidr { get; set; } = string.Empty;

		/// <summary>
		/// Dest port
		/// </summary>
		[DataMember(Name = "destPort")]
		public string DestPort { get; set; } = string.Empty;

		/// <summary>
		/// Policy
		/// </summary>
		[DataMember(Name = "policy")]
		public string Policy { get; set; } = string.Empty;

		/// <summary>
		/// Comment
		/// </summary>
		[DataMember(Name = "comment")]
		public string Comment { get; set; } = string.Empty;
	}
}
