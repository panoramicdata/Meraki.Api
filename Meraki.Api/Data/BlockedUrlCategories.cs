using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for blacklisted URL categories
	/// </summary>
	[DataContract]
	public partial class BlockedUrlCategories
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public Setting Settings { get; set; }

		/// <summary>
		/// A list of URL categories to block
		/// </summary>
		/// <value>A list of URL categories to block</value>
		[DataMember(Name = "categories", EmitDefaultValue = false)]
		public List<string> Categories { get; set; } = null!;
	}
}
