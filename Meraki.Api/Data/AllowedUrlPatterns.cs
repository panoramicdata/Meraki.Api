using Newtonsoft.Json;
using System;using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for whitelisted URL patterns
	/// </summary>
	[DataContract]
	public partial class AllowedUrlPatterns
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AllowedUrlPatterns" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>
		/// <param name="Patterns">A whitelist of URL patterns to allow.</param>
		public AllowedUrlPatterns(Settings2 Settings = default, List<string> Patterns = default)
		{
			this.Settings = Settings;
			this.Patterns = Patterns;
		}

		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public Settings2 Settings { get; set; }
		/// <summary>
		/// A whitelist of URL patterns to allow
		/// </summary>
		/// <value>A whitelist of URL patterns to allow</value>
		[DataMember(Name = "patterns", EmitDefaultValue = false)]
		public List<string> Patterns { get; set; }
	}
}