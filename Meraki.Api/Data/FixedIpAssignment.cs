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
	}
}