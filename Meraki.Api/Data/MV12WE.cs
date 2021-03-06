using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Quality and resolution for MV12WE camera models.
	/// </summary>
	[DataContract]
	public partial class Mv12we
	{
		/// <summary>
		/// Gets or Sets Quality
		/// </summary>
		[DataMember(Name = "quality", EmitDefaultValue = false)]
		public StandardEnhancedHighQuality Quality { get; set; }

		/// <summary>
		/// Gets or Sets Resolution
		/// </summary>
		[DataMember(Name = "resolution", EmitDefaultValue = false)]
		public Mv02Resolution Resolution { get; set; }
	}
}
