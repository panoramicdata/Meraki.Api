using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Port
/// </summary>
[DataContract]
public class Port
{
	/// <summary>
	/// CDP
	/// </summary>
	[DataMember(Name = "cdp")]
	public Cdp? Cdp { get; set; }

	/// <summary>
	/// LLDP
	/// </summary>
	[DataMember(Name = "lldp")]
	public Lldp? Lldp { get; set; }
}
