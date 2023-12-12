namespace Meraki.Api.Data;

/// <summary>
/// Hotspot 20
/// </summary>
[DataContract]
public class Hotspot20
{
	/// <summary>
	/// Whether or not Hotspot 2.0 for this SSID is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Operator settings for this SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "operator")]
	public Operator Operator { get; set; } = new();

	/// <summary>
	/// Venue settings for this SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "venue")]
	public Venue Venue { get; set; } = new();

	/// <summary>
	/// Network access type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "networkAccessType")]
	public string NetworkAccessType { get; set; } = string.Empty;

	/// <summary>
	/// An array of domain names
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "domains")]
	public List<string> Domains { get; set; } = [];

	/// <summary>
	/// An array of roaming consortium OIs (hexadecimal number 3-5 octets in length)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "roamConsortOis")]
	public List<string> RoamConsortOis { get; set; } = [];

	/// <summary>
	/// An array of MCC/MNC pairs
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mccMncs")]
	public List<MccMncs> MccMncs { get; set; } = [];

	/// <summary>
	/// An array of NAI realms
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "naiRealms")]
	public List<NaiRealm> NaiRealms { get; set; } = [];
}
