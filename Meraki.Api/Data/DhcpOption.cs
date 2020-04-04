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
		[DataMember(Name = "code")]
		public long Code { get; set; }

		/// <summary>
		/// type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// value
		/// </summary>
		[DataMember(Name = "value")]
		public string Value { get; set; } = string.Empty;
	}
}