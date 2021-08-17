using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkWirelessRfProfile
	/// </summary>
	[DataContract]
	public partial class WirelessRfProfileCreationRequest
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string? Id { get; set; }

		/// <summary>
		///	Network id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string? NetworkId { get; set; }

		/// <summary>
		/// The name of the new profile. Must be unique. This param is required on creation.
		/// </summary>
		/// <value>The name of the new profile. Must be unique. This param is required on creation.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Steers client to best available access point. Can be either true or false. Defaults to true.
		/// </summary>
		/// <value>Steers client to best available access point. Can be either true or false. Defaults to true.</value>
		[DataMember(Name = "clientBalancingEnabled", EmitDefaultValue = false)]
		public bool? ClientBalancingEnabled { get; set; }

		/// <summary>
		/// Gets or Sets MinBitrateType
		/// </summary>
		[DataMember(Name = "minBitrateType", EmitDefaultValue = false)]
		public MinBitrateType MinBitrateType { get; set; }

		/// <summary>
		/// Gets or Sets BandSelectionType
		/// </summary>
		[DataMember(Name = "bandSelectionType", EmitDefaultValue = false)]
		public BandSelectionType BandSelectionType { get; set; }

		/// <summary>
		/// Gets or Sets ApBandSettings
		/// </summary>
		[DataMember(Name = "apBandSettings", EmitDefaultValue = false)]
		public ApBandSettings ApBandSettings { get; set; } = null!;

		/// <summary>
		/// Gets or Sets TwoFourGhzSettings
		/// </summary>
		[DataMember(Name = "twoFourGhzSettings", EmitDefaultValue = false)]
		public TwoPointFourGhzSettings TwoFourGhzSettings { get; set; } = null!;

		/// <summary>
		/// Gets or Sets FiveGhzSettings
		/// </summary>
		[DataMember(Name = "fiveGhzSettings", EmitDefaultValue = false)]
		public FiveGhzSettings FiveGhzSettings { get; set; } = null!;
	}
}
