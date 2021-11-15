namespace Meraki.Api.Data;

/// <summary>
/// Hotspot 20
/// </summary>
[DataContract]
public class Hotspot20
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Operator
	/// </summary>
	[DataMember(Name = "operator")]
	public Operator Operator { get; set; } = new();

	/// <summary>
	/// Venue
	/// </summary>
	[DataMember(Name = "venue")]
	public Venue Venue { get; set; } = new();

	/// <summary>
	/// Network access type
	/// </summary>
	[DataMember(Name = "networkAccessType")]
	public string NetworkAccessType { get; set; } = string.Empty;

	/// <summary>
	/// Domains
	/// </summary>
	[DataMember(Name = "domains")]
	public List<string> Domains { get; set; } = new();

	/// <summary>
	/// RoamConsortOis
	/// </summary>
	[DataMember(Name = "roamConsortOis")]
	public List<string> RoamConsortOis { get; set; } = new();

	/// <summary>
	/// Mcc Mncs
	/// </summary>
	[DataMember(Name = "mccMncs")]
	public List<MccMncs> MccMncs { get; set; } = new();

	/// <summary>
	/// Nai Realms
	/// </summary>
	[DataMember(Name = "naiRealms")]
	public NaiRealms NaiRealms { get; set; } = new();
}
