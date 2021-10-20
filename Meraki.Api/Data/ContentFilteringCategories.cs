using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Content filtering catergories
	/// </summary>
	[DataContract]
	public class ContentFilteringCategories
	{
		/// <summary>
		/// Categories
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "categories")]
		public List<NamedIdentifiedItem> Categories { get; set; } = new();
	}
}