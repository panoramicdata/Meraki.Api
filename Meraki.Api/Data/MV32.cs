using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Quality and resolution for MV32 camera models.
	/// </summary>
	[DataContract]
	public partial class Mv32
	{
		/// <summary>
		/// Gets or Sets Quality
		/// </summary>
		[DataMember(Name = "quality", EmitDefaultValue = false)]
		public StandardEnhancedQuality Quality { get; set; }

		/// <summary>
		/// Gets or Sets Resolution
		/// </summary>
		[DataMember(Name = "resolution", EmitDefaultValue = false)]
		public Mv32Resolution Resolution { get; set; }
	}
}
