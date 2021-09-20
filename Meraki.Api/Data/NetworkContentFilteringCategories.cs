using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "categories")]
		public List<Categories> Categories { get; set; } = new();
	}
}