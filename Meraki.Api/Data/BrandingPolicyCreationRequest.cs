using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateOrganizationBrandingPolicy
	/// </summary>
	[DataContract]
	public class BrandingPolicyCreationRequest
	{
		/// <summary>
		/// Name of the Dashboard branding policy.
		/// </summary>
		/// <value>Name of the Dashboard branding policy.</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

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
		public AdminSettings AdminSettings { get; set; } = null!;

		/// <summary>
		/// Gets or Sets HelpSettings
		/// </summary>
		[DataMember(Name = "helpSettings")]
		public HelpSettings HelpSettings { get; set; } = null!;
	}
}
