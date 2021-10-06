using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings for describing the modifications to various Help page features. Each property in this object accepts one of 'default or inherit' (do not modify functionality), 'hide' (remove the section from Dashboard), or 'show' (always show the section on Dashboard). Some properties in this object also accept custom HTML used to replace the section on Dashboard; see the documentation for each property to see the allowed values. Each property defaults to 'default or inherit' when not provided.
	/// </summary>
	[DataContract]
	public class HelpSettings
	{
		/// <summary>
		/// Gets or Sets HelpTab
		/// </summary>
		/// <remarks>
		/// The Help tab, under which all support information resides. If this tab is hidden, no other 'Help' branding customizations will be visible. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "helpTab")]
		public BrandingPolicyHelpSetting HelpTab { get; set; }

		/// <summary>
		/// Gets or Sets GetHelpSubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> Get Help' subtab on which Cisco Meraki KB, Product Manuals, and Support/Case Information are displayed. Note that if this subtab is hidden, branding customizations for the KB on 'Get help', Cisco Meraki product documentation, and support contact info will not be visible. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "getHelpSubtab")]
		public BrandingPolicyHelpSetting GetHelpSubtab { get; set; }

		/// <summary>
		/// Gets or Sets CommunitySubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> Community' subtab which provides a link to Meraki Community. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "communitySubtab")]
		public BrandingPolicyHelpSetting CommunitySubtab { get; set; }

		/// <summary>
		/// Gets or Sets CasesSubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> Cases' Dashboard subtab on which Cisco Meraki support cases for this organization can be managed. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "casesSubtab")]
		public BrandingPolicyHelpSetting CasesSubtab { get; set; }

		/// <summary>
		/// Gets or Sets DataProtectionRequestsSubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> Data protection requests' Dashboard subtab on which requests to delete, restrict, or export end-user data can be audited. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dataProtectionRequestsSubtab")]
		public BrandingPolicyHelpSetting DataProtectionRequestsSubtab { get; set; }

		/// <summary>
		/// The KB search box which appears on the Help page. Can be one of 'default or inherit', 'hide', 'show', or a replacement custom HTML string.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "getHelpSubtabKnowledgeBaseSearch")]
		public string GetHelpSubtabKnowledgeBaseSearch { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UniversalSearchKnowledgeBaseSearch
		/// </summary>
		/// <remarks>
		/// The universal search box always visible on Dashboard will, by default, present results from the Meraki KB. This configures whether these Meraki KB results should be returned. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "universalSearchKnowledgeBaseSearch")]
		public BrandingPolicyHelpSetting UniversalSearchKnowledgeBaseSearch { get; set; }

		/// <summary>
		/// The 'Product Manuals' section of the 'Help -> Get Help' subtab. Can be one of 'default or inherit', 'hide', 'show', or a replacement custom HTML string.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "ciscoMerakiProductDocumentation")]
		public string CiscoMerakiProductDocumentation { get; set; } = string.Empty;

		/// <summary>
		/// The 'Contact Meraki Support' section of the 'Help -> Get Help' subtab. Can be one of 'default or inherit', 'hide', 'show', or a replacement custom HTML string.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "supportContactInfo")]
		public string SupportContactInfo { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets NewFeaturesSubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> New features' subtab where new Dashboard features are detailed.Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "newFeaturesSubtab")]
		public BrandingPolicyHelpSetting NewFeaturesSubtab { get; set; }

		/// <summary>
		/// Gets or Sets FirewallInfoSubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> Firewall info' subtab where necessary upstream firewall rules for communication to the Cisco Meraki cloud are listed. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "firewallInfoSubtab")]
		public BrandingPolicyHelpSetting FirewallInfoSubtab { get; set; }

		/// <summary>
		/// Gets or Sets ApiDocsSubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> API docs' subtab where a detailed description of the Dashboard API is listed. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "apiDocsSubtab")]
		public BrandingPolicyHelpSetting ApiDocsSubtab { get; set; }

		/// <summary>
		/// Gets or Sets HardwareReplacementsSubtab
		/// </summary>
		/// <remarks>
		/// The 'Help -> Replacement info' subtab where important information regarding device replacements is detailed. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "hardwareReplacementsSubtab")]
		public BrandingPolicyHelpSetting HardwareReplacementsSubtab { get; set; }

		/// <summary>
		/// Gets or Sets SmForums
		/// </summary>
		/// <remarks>
		/// The 'SM Forums' subtab which links to community-based support for Cisco Meraki Systems Manager. Only configurable for organizations that contain Systems Manager networks. Can be one of 'default or inherit', 'hide' or 'show'.
		/// </remarks>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "smForums")]
		public BrandingPolicyHelpSetting SmForums { get; set; }
	}
}
