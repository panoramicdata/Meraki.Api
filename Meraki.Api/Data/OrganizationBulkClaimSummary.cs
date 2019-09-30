using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A license claim
	/// </summary>
	[DataContract]
	public class OrganizationBulkClaim
	{
		/// <summary>
		/// Orders
		/// </summary>
		[DataMember(Name = "orders")]
		public List<string> Orders { get; set; } = null!;

		/// <summary>
		/// Serials
		/// </summary>
		[DataMember(Name = "serials")]
		public List<string> Serials { get; set; } = null!;

		/// <summary>
		/// licenses
		/// </summary>
		[DataMember(Name = "licenses")]
		public List<LicenseClaim> Licenses { get; set; } = null!;
	}
}