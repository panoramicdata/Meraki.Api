using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class OrganizationApi
	{
		/// <summary>
		/// If true, enable the access to the Cisco Meraki Dashboard API
		/// </summary>
		[DataMember(Name = "enabled")]
		[ApiAccess(ApiAccess.ReadUpdate)]
		public bool Enabled { get; set; }
	}
}