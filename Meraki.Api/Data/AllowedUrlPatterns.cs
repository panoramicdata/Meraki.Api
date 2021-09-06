using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for whitelisted URL patterns
	/// </summary>
	[DataContract]
	public class AllowedUrlPatterns
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public Setting Settings { get; set; } = new();

		/// <summary>
		/// A whitelist of URL patterns to allow
		/// </summary>
		/// <value>A whitelist of URL patterns to allow</value>
		[DataMember(Name = "patterns", EmitDefaultValue = false)]
		public List<string> Patterns { get; set; } = new();
	}
}