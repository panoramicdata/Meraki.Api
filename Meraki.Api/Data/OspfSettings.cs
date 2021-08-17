using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// OSPF settings
	/// </summary>
	[DataContract]
	public partial class OspfSettings
	{
		/// <summary>
		/// Area
		/// </summary>
		[DataMember(Name = "area")]
		public string Area { get; set; } = string.Empty;

		/// <summary>
		/// Cost
		/// </summary>
		[DataMember(Name = "cost")]
		public int Cost { get; set; } = 0;

		/// <summary>
		/// Is passive enabled
		/// </summary>
		[DataMember(Name = "isPassiveEnabled")]
		public bool IsPassiveEnabled { get; set; }
	}
}
