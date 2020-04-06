using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkWirelessRfProfile
	/// </summary>
	[DataContract]
	public partial class WirelessRfProfileUpdateRequest
	{
		/// <summary>
		/// The name of the new profile. Must be unique.
		/// </summary>
		/// <value>The name of the new profile. Must be unique.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Steers client to best available access point. Can be either true or false.
		/// </summary>
		/// <value>Steers client to best available access point. Can be either true or false.</value>
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
		public TwoPointFourGhzSettings TwoPointFourGhzSettings { get; set; } = null!;

		/// <summary>
		/// Gets or Sets FiveGhzSettings
		/// </summary>
		[DataMember(Name = "fiveGhzSettings", EmitDefaultValue = false)]
		public FiveGhzSettings FiveGhzSettings { get; set; } = null!;
	}
}
