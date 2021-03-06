using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Quality and resolution for MV22X/MV72X camera models.
	/// </summary>
	[DataContract]
	public partial class Mv22xMv72x
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
		public Mv22xMv72xResolution Resolution { get; set; }
	}
}
