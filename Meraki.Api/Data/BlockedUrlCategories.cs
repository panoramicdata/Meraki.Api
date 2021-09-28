using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for blacklisted URL categories
	/// </summary>
	[DataContract]
	public class BlockedUrlCategories
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings")]
		public Setting Settings { get; set; }

		/// <summary>
		/// A list of URL categories to block
		/// </summary>
		/// <value>A list of URL categories to block</value>
		[DataMember(Name = "categories")]
		public List<string> Categories { get; set; } = null!;
	}
}
