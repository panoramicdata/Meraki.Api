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
		public Wan? Wan1 { get; set; }

		/// <summary>
		/// WAN 2 spec
		/// </summary>
		[DataMember(Name = "wan2")]
		public Wan? Wan2 { get; set; }
	}
}
