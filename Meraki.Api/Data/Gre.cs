namespace Meraki.Api.Data;

/// <summary>
/// Ethernet over GRE settings
/// </summary>
public class Gre
{
	/// <summary>
	/// Optional numerical identifier that will add the GRE key field to the GRE header. Used to identify an individual traffic flow within a tunnel.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "key")]
	public string? Key { get; set; }

	/// <summary>
	/// The EoGRE concentrator's settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "concentrator")]
	public GreConcentrator? Concentrator { get; set; }

}