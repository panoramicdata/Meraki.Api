using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Nai realms
	/// </summary>
	public class NaiRealms
	{
		/// <summary>
		/// Format
		/// </summary>
		[DataMember(Name = "format")]
		public int Format { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Methods
		/// </summary>
		[DataMember(Name = "methods")]
		public List<Methods> Methods { get; set; } = new();
	}
}
