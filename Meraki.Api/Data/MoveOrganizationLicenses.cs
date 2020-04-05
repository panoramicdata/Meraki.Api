using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// MoveOrganizationLicenses
	/// </summary>
	[DataContract]
	public partial class MoveOrganizationLicenses
	{
		/// <summary>
		/// The ID of the organization to move the licenses to
		/// </summary>
		/// <value>The ID of the organization to move the licenses to</value>
		[DataMember(Name = "destOrganizationId", EmitDefaultValue = false)]
		public string DestOrganizationId { get; set; } = null!;

		/// <summary>
		/// A list of IDs of licenses to move to the new organization
		/// </summary>
		/// <value>A list of IDs of licenses to move to the new organization</value>
		[DataMember(Name = "licenseIds", EmitDefaultValue = false)]
		public List<string> LicenseIds { get; set; } = null!;
	}
}
