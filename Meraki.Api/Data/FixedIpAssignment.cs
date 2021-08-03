using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class FixedIpAssignment : NamedItem
	{
		/// <summary>
		/// IP Address
		/// </summary>
		[DataMember(Name = "ip")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// MAC
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;
	}
}