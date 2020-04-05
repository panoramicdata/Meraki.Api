using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An object describing the bandwidth settings for your rule.
	/// </summary>
	[DataContract]
	public partial class PerClientBandwidthLimits
	{
		/// <summary>
		/// How bandwidth limits are applied by your rule. Can be one of &#39;network default&#39;, &#39;ignore&#39; or &#39;custom&#39;.
		/// </summary>
		/// <value>How bandwidth limits are applied by your rule. Can be one of &#39;network default&#39;, &#39;ignore&#39; or &#39;custom&#39;.</value>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public string Settings { get; set; } = null!;

		/// <summary>
		/// Gets or Sets BandwidthLimits
		/// </summary>
		[DataMember(Name = "bandwidthLimits", EmitDefaultValue = false)]
		public BandwidthLimits BandwidthLimits { get; set; } = null!;
	}
}
