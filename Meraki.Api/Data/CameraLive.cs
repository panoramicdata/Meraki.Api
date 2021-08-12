using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Camera live
	/// </summary>
	[DataContract]
	public class CameraLive
	{
		/// <summary>
		/// Ts
		/// </summary>
		[DataMember(Name = "ts")]
		public string Ts { get; set; } = string.Empty;

		/// <summary>
		/// Zones
		/// </summary>
		[DataMember(Name = "zones")]
		public Zones Zones { get; set; } = new();
	}
}
