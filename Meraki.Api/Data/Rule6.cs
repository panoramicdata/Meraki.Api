using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule6
	/// </summary>
	[DataContract]
	public partial class Rule6
	{
		/// <summary>
		/// Gets or Sets Policy
		/// </summary>
		[DataMember(Name = "policy", EmitDefaultValue = false)]
		public Policy5 Policy { get; set; }
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public Layer7RuleType Type { get; set; }
		/// <summary>
		/// The &#39;value&#39; of what you want to block. Format of &#39;value&#39; varies depending on type of the rule. See sample request. The application categories and application ids can be retrieved from the &#39;MX L7 application categories&#39; endpoint. The countries follow the two-letter ISO 3166-1 alpha-2 format.
		/// </summary>
		/// <value>The &#39;value&#39; of what you want to block. Format of &#39;value&#39; varies depending on type of the rule. See sample request. The application categories and application ids can be retrieved from the &#39;MX L7 application categories&#39; endpoint. The countries follow the two-letter ISO 3166-1 alpha-2 format.</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; } = null!;
	}
}
