﻿using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network Client Connection Stats
	/// </summary>
	[DataContract]
	public class NetworkClientConnectionStats
	{
		/// <summary>
		/// mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// connectionStats
		/// </summary>
		[DataMember(Name = "connectionStats")]
		public ConnectionStats ConnnectionStats { get; set; } = null!;
	}
}