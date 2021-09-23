using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class IpRestrictionsForKeys
	{
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		[DataMember(Name = "ranges")]
		public List<string> Ranges { get; set; } = new();
	}
}