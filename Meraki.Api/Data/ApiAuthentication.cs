using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class ApiAuthentication
	{
		[DataMember(Name = "ipRestrictionsForKeys")]
		public IpRestrictionsForKeys IpRestrictionsForKeys { get; set; } = new();
	}
}