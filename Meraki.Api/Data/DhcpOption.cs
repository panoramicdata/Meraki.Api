using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A DHCP option
	/// </summary>
	[DataContract]
	public class DhcpOption
	{
		/// <summary>
		/// code
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "code")]
		public long Code { get; set; }

		/// <summary>
		/// type
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "type")]
		public DhcpOptionType Type { get; set; }

		/// <summary>
		/// value
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "value")]
		public string Value { get; set; } = string.Empty;
	}
}