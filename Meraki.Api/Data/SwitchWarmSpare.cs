using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Warm spare config
	/// </summary>
	[DataContract]
	public class SwitchWarmSpare
	{
		/// <summary>
		/// Enabled
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Primary serial
		/// </summary>
		[DataMember(Name = "primarySerial")]
		public string PrimarySerial { get; set; } = string.Empty;

		/// <summary>
		/// Spare serial
		/// </summary>
		[DataMember(Name = "spareSerial")]
		public string SpareSerial { get; set; } = string.Empty;
	}
}
