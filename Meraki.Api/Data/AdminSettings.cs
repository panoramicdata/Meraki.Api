using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for describing which kinds of admins this policy applies to.
	/// </summary>
	[DataContract]
	public partial class AdminSettings
	{
		/// <summary>
		/// Gets or Sets AppliesTo
		/// </summary>
		[DataMember(Name = "appliesTo", EmitDefaultValue = false)]
		public AppliesTo AppliesTo { get; set; }

		/// <summary>
		/// If &#39;appliesTo&#39; is set to one of &#39;Specific admins...&#39;, &#39;All admins of networks...&#39; or &#39;All admins of networks tagged...&#39;, then you must specify this &#39;values&#39; property to provide the set of     entities to apply the branding policy to. For &#39;Specific admins...&#39;, specify an array of admin IDs. For &#39;All admins of     networks...&#39;, specify an array of network IDs and/or configuration template IDs. For &#39;All admins of networks tagged...&#39;,     specify an array of tag names.
		/// </summary>
		/// <value>If &#39;appliesTo&#39; is set to one of &#39;Specific admins...&#39;, &#39;All admins of networks...&#39; or &#39;All admins of networks tagged...&#39;, then you must specify this &#39;values&#39; property to provide the set of     entities to apply the branding policy to. For &#39;Specific admins...&#39;, specify an array of admin IDs. For &#39;All admins of     networks...&#39;, specify an array of network IDs and/or configuration template IDs. For &#39;All admins of networks tagged...&#39;,     specify an array of tag names.</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<string>? Values { get; set; }
	}
}