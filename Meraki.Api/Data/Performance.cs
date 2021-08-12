using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Performance
	/// </summary>
	[DataContract]
	public class Performance
	{
		/// <summary>
		/// Performance score
		/// </summary>
		[DataMember(Name = "perfScore")]
		public int PerfScore { get; set; }
	}
}
