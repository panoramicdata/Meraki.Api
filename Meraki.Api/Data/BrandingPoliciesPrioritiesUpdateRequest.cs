using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationBrandingPoliciesPriorities
	/// </summary>
	[DataContract]
	public class BrandingPoliciesPrioritiesUpdateRequest
	{
		/// <summary>
		/// A list of branding policy IDs arranged in ascending priority order (IDs later in the array have higher priority).
		/// </summary>
		/// <value>A list of branding policy IDs arranged in ascending priority order (IDs later in the array have higher priority).</value>
		[DataMember(Name = "brandingPolicyIds", EmitDefaultValue = false)]
		public List<string> BrandingPolicyIds { get; set; } = new();
	}
}
