using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Zone data
	/// </summary>
	[DataContract]
	public class ZoneData
	{
		/// <summary>
		/// Person
		/// </summary>
		public int Person { get; set; }
	}
}
