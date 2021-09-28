using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationBrandingPolicy
	/// </summary>
	[DataContract]
	public class BrandingPolicyUpdateRequest
	{
		/// <summary>
		/// Name of the Dashboard branding policy.
		/// </summary>
		/// <value>Name of the Dashboard branding policy.</value>
		[DataMember(Name = "name")]
		public string? Name { get; set; }

		/// <summary>
		/// Boolean indicating whether this policy is enabled.
		/// </summary>
		/// <value>Boolean indicating whether this policy is enabled.</value>
		[DataMember(Name = "enabled")]
		public bool? Enabled { get; set; }

		/// <summary>
		/// Gets or Sets AdminSettings
		/// </summary>
		[DataMember(Name = "adminSettings")]
		public AdminSettings? AdminSettings { get; set; }

		/// <summary>
		/// Gets or Sets HelpSettings
		/// </summary>
		[DataMember(Name = "helpSettings")]
		public BrandingPolicyHelpSettings HelpSettings { get; set; } = new();
	}
}
