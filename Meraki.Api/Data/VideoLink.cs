using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Video link
	/// </summary>
	[DataContract]
	public class VideoLink
	{
		/// <summary>
		/// Url
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}
