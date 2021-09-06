using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// ClaimRequest
	/// </summary>
	[DataContract]
	public class OrganizationClaimResponse
	{
		/// <summary>
		/// The numbers of the orders that should be claimed
		/// </summary>
		/// <value>The numbers of the orders that should be claimed</value>
		[DataMember(Name = "orders", EmitDefaultValue = false)]
		public List<string> Orders { get; set; } = new();

		/// <summary>
		/// The serials of the devices that should be claimed
		/// </summary>
		/// <value>The serials of the devices that should be claimed</value>
		[DataMember(Name = "serials", EmitDefaultValue = false)]
		public List<string> Serials { get; set; } = new();

		/// <summary>
		/// The licenses that should be claimed
		/// </summary>
		/// <value>The licenses that should be claimed</value>
		[DataMember(Name = "licenses", EmitDefaultValue = false)]
		public List<License> Licenses { get; set; } = new();
	}
}
