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
		/// Code
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "code")]
		public int Code { get; set; }

		/// <summary>
		/// Type
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "type")]
		public DhcpOptionType Type { get; set; }

		/// <summary>
		/// Value
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "value")]
		public string Value { get; set; } = string.Empty;
	}
}