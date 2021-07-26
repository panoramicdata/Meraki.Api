using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Last upgrade
	/// </summary>
	[DataContract]
	public partial class LastUpgrade
	{
		/// <summary>
		/// Time
		/// </summary>
		[DataMember(Name = "time")]
		public string Time { get; set; } = string.Empty;

		/// <summary>
		/// From version
		/// </summary>
		[DataMember(Name = "fromVersion")]
		public Version FromVersion { get; set; } = new();

		/// <summary>
		/// To version
		/// </summary>
		[DataMember(Name = "toVersion")]
		public Version ToVersion { get; set; } = new();	
	}
}
