using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for blacklisted URL patterns
	/// </summary>
	[DataContract]
	public partial class BlockedUrlPatterns
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public Setting Settings { get; set; }

		/// <summary>
		/// A blacklist of URL patterns to block
		/// </summary>
		/// <value>A blacklist of URL patterns to block</value>
		[DataMember(Name = "patterns", EmitDefaultValue = false)]
		public List<string> Patterns { get; set; } = null!;
	}
}
