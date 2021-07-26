using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Next upgrade
	/// </summary>
	[DataContract]
	public partial class NextUpgrade
	{
		/// <summary>
		/// Time
		/// </summary>
		[DataMember(Name = "time")]
		public string Time { get; set; } = string.Empty;

		/// <summary>
		/// To version
		/// </summary>
		[DataMember(Name = "toVersion")]
		public Version ToVersion { get; set; } = new();
	}
}
