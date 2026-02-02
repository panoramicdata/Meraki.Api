namespace Meraki.Api.Data;

/// <summary>
/// End of life (EOX) information for a device
/// </summary>
[DataContract]
public class Eox
{
	/// <summary>
	/// End of life status (e.g., "endOfSale", "endOfSupport"). Undocumented property.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// End of sale date. Undocumented property.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endOfSaleAt")]
	public DateTime? EndOfSaleAt { get; set; }

	/// <summary>
	/// End of support date. Undocumented property.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endOfSupportAt")]
	public DateTime? EndOfSupportAt { get; set; }
}
