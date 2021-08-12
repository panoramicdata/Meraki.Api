using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Content filtering catergories
	/// </summary>
	[DataContract]
	public class NetworkContentFilteringCategories
	{
		/// <summary>
		/// Categories
		/// </summary>
		[DataMember(Name = "categories")]
		public List<Categories> Categories { get; set; } = new();
	}
}