using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Response
	/// </summary>
	[DataContract]
	public class AssignSeatsResponse
	{
		/// <summary>
		/// Resulting licenses
		/// </summary>
		[DataMember(Name = "resultingLicenses")]
		public List<OrganizationLicense> ResultingLicenses { get; set; } = new();
	}
}
