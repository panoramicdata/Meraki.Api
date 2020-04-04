using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class WanSpecs
	{
		/// <summary>
		/// Dynamic DNS Hostnames
		/// </summary>
		[DataMember(Name = "ddnsHostnames")]
		public DdnsHostnames? DdnsHostnames { get; set; }

		/// <summary>
		/// WAN 1 spec
		/// </summary>
		[DataMember(Name = "wan1")]
		public WanSpec? WanSpec1 { get; set; }

		/// <summary>
		/// WAN 2 spec
		/// </summary>
		[DataMember(Name = "wan2")]
		public WanSpec? WanSpec2 { get; set; }
	}
}
