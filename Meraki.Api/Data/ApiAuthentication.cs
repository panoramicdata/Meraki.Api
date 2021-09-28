using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class ApiAuthentication
	{
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "ipRestrictionsForKeys")]
		public IpRestrictionsForKeys IpRestrictionsForKeys { get; set; } = new();
	}
}