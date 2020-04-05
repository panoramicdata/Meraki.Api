using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Video quality and resolution settings for all the camera models.
	/// </summary>
	[DataContract]
	public partial class VideoSettings
	{
		/// <summary>
		/// Gets or Sets MV21MV71
		/// </summary>
		[DataMember(Name = "MV21/MV71", EmitDefaultValue = false)]
		public Mv21Mv71 Mv21Mv71 { get; set; } = null!;
		/// <summary>
		/// Gets or Sets MV12MV22MV72
		/// </summary>
		[DataMember(Name = "MV12/MV22/MV72", EmitDefaultValue = false)]
		public Mv12Mv22Mv72 Mv12Mv22Mv72 { get; set; } = null!;
		/// <summary>
		/// Gets or Sets MV32
		/// </summary>
		[DataMember(Name = "MV32", EmitDefaultValue = false)]
		public Mv32 Mv32 { get; set; } = null!;
		/// <summary>
		/// Gets or Sets MV12WE
		/// </summary>
		[DataMember(Name = "MV12WE", EmitDefaultValue = false)]
		public Mv12we Mv12we { get; set; } = null!;
		/// <summary>
		/// Gets or Sets MV22XMV72X
		/// </summary>
		[DataMember(Name = "MV22X/MV72X", EmitDefaultValue = false)]
		public Mv22xMv72x Mv22xMv72x { get; set; } = null!;
		/// <summary>
		/// Gets or Sets MV02
		/// </summary>
		[DataMember(Name = "MV02", EmitDefaultValue = false)]
		public Mv02 Mv02 { get; set; } = null!;
	}
}
