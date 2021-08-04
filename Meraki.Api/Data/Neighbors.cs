using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Neighbors
	/// </summary>
	[DataContract]
	public partial class Neighbors
	{
		/// <summary>
		/// Ip
		/// </summary>
		[DataMember(Name = "ip")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// Remote as number
		/// </summary>
		[DataMember(Name = "remoteAsNumber")]
		public int RemoteAsNumber { get; set; }

		/// <summary>
		/// Receive limit
		/// </summary>
		[DataMember(Name = "receiveLimit")]
		public int ReceiveLimit { get; set; }

		/// <summary>
		/// Allow transit
		/// </summary>
		[DataMember(Name = "allowTransit")]
		public bool AllowTransit { get; set; }

		/// <summary>
		/// Ebgp hold timer
		/// </summary>
		[DataMember(Name = "ebgpHoldTimer")]
		public int EbgpHoldTimer { get; set; }

		/// <summary>
		/// Ebgp Multihop
		/// </summary>
		[DataMember(Name = "ebgpMultihop")]
		public int EbgpMultihop { get; set; }
	}
}
