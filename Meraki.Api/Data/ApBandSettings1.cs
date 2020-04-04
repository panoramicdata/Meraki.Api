using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings that will be enabled if selectionType is set to &#39;ap&#39;.
	/// </summary>
	[DataContract]
	public partial class ApBandSettings1
	{
		/// <summary>
		/// Gets or Sets BandOperationMode
		/// </summary>
		[DataMember(Name = "bandOperationMode", EmitDefaultValue = false)]
		public BandOperationMode1 BandOperationMode { get; set; }
		/// <summary>
		/// Steers client to most open band. Can be either true or false.
		/// </summary>
		/// <value>Steers client to most open band. Can be either true or false.</value>
		[DataMember(Name = "bandSteeringEnabled", EmitDefaultValue = false)]
		public bool? BandSteeringEnabled { get; set; }
	}
}
