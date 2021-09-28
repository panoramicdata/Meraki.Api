using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for describing the modifications to various Help page features. Each property in this object accepts one of     &#39;default or inherit&#39; (do not modify functionality), &#39;hide&#39; (remove the section from Dashboard), or &#39;show&#39; (always show     the section on Dashboard). Some properties in this object also accept custom HTML used to replace the section on     Dashboard; see the documentation for each property to see the allowed values.
	/// </summary>
	[DataContract]
	public class BrandingPolicyHelpSettings
	{
		/// <summary>
		/// Gets or Sets HelpTab
		/// </summary>
		[DataMember(Name = "helpTab")]
		public HelpTab HelpTab { get; set; }
		/// <summary>
		/// Gets or Sets GetHelpSubtab
		/// </summary>
		[DataMember(Name = "getHelpSubtab")]
		public GetHelpSubtab GetHelpSubtab { get; set; }
		/// <summary>
		/// Gets or Sets CommunitySubtab
		/// </summary>
		[DataMember(Name = "communitySubtab")]
		public CommunitySubtab CommunitySubtab { get; set; }
		/// <summary>
		/// Gets or Sets CasesSubtab
		/// </summary>
		[DataMember(Name = "casesSubtab")]
		public CasesSubtab CasesSubtab { get; set; }
		/// <summary>
		/// Gets or Sets DataProtectionRequestsSubtab
		/// </summary>
		[DataMember(Name = "dataProtectionRequestsSubtab")]
		public DataProtectionRequestsSubtab DataProtectionRequestsSubtab { get; set; }
		/// <summary>
		/// The KB search box which appears on the Help page. Can be one of &#39;default or inherit&#39;, &#39;hide&#39;, &#39;show&#39;, or a replacement custom HTML string.
		/// </summary>
		/// <value>The KB search box which appears on the Help page. Can be one of &#39;default or inherit&#39;, &#39;hide&#39;, &#39;show&#39;, or a replacement custom HTML string.</value>
		[DataMember(Name = "getHelpSubtabKnowledgeBaseSearch")]
		public string GetHelpSubtabKnowledgeBaseSearch { get; set; } = string.Empty;
		/// <summary>
		/// Gets or Sets UniversalSearchKnowledgeBaseSearch
		/// </summary>
		[DataMember(Name = "universalSearchKnowledgeBaseSearch")]
		public UniversalSearchKnowledgeBaseSearch UniversalSearchKnowledgeBaseSearch { get; set; }
		/// <summary>
		/// The &#39;Product Manuals&#39; section of the &#39;Help -&gt; Get Help&#39; subtab. Can be one of &#39;default or inherit&#39;, &#39;hide&#39;, &#39;show&#39;, or a replacement custom HTML string.
		/// </summary>
		/// <value>The &#39;Product Manuals&#39; section of the &#39;Help -&gt; Get Help&#39; subtab. Can be one of &#39;default or inherit&#39;, &#39;hide&#39;, &#39;show&#39;, or a replacement custom HTML string.</value>
		[DataMember(Name = "ciscoMerakiProductDocumentation")]
		public string CiscoMerakiProductDocumentation { get; set; } = string.Empty;
		/// <summary>
		/// The &#39;Contact Meraki Support&#39; section of the &#39;Help -&gt; Get Help&#39; subtab. Can be one of &#39;default or inherit&#39;, &#39;hide&#39;, &#39;show&#39;, or a replacement custom HTML string.
		/// </summary>
		/// <value>The &#39;Contact Meraki Support&#39; section of the &#39;Help -&gt; Get Help&#39; subtab. Can be one of &#39;default or inherit&#39;, &#39;hide&#39;, &#39;show&#39;, or a replacement custom HTML string.</value>
		[DataMember(Name = "supportContactInfo")]
		public string SupportContactInfo { get; set; } = string.Empty;
		/// <summary>
		/// Gets or Sets NewFeaturesSubtab
		/// </summary>
		[DataMember(Name = "newFeaturesSubtab")]
		public NewFeaturesSubtab NewFeaturesSubtab { get; set; }
		/// <summary>
		/// Gets or Sets FirewallInfoSubtab
		/// </summary>
		[DataMember(Name = "firewallInfoSubtab")]
		public FirewallInfoSubtab FirewallInfoSubtab { get; set; }
		/// <summary>
		/// Gets or Sets ApiDocsSubtab
		/// </summary>
		[DataMember(Name = "apiDocsSubtab")]
		public ApiDocsSubtab ApiDocsSubtab { get; set; }
		/// <summary>
		/// Gets or Sets HardwareReplacementsSubtab
		/// </summary>
		[DataMember(Name = "hardwareReplacementsSubtab")]
		public HardwareReplacementsSubtab HardwareReplacementsSubtab { get; set; }
		/// <summary>
		/// Gets or Sets SmForums
		/// </summary>
		[DataMember(Name = "smForums")]
		public SmForum SmForums { get; set; }
	}
}
