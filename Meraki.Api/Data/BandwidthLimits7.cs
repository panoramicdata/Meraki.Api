using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A mapping of uplinks to their bandwidth settings (be sure to check which uplinks are supported for your network)
	/// </summary>
	[DataContract]
	public partial class BandwidthLimits7
	{
		/// <summary>
		/// Gets or Sets Wan1
		/// </summary>
		[DataMember(Name = "wan1", EmitDefaultValue = false)]
		public Wan11 Wan1 { get; set; }
		/// <summary>
		/// Gets or Sets Wan2
		/// </summary>
		[DataMember(Name = "wan2", EmitDefaultValue = false)]
		public Wan21 Wan2 { get; set; }
		/// <summary>
		/// Gets or Sets Cellular
		/// </summary>
		[DataMember(Name = "cellular", EmitDefaultValue = false)]
		public Cellular Cellular { get; set; }
	}
}
