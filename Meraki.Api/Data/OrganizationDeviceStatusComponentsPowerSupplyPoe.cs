namespace Meraki.Api.Data;

/// <summary>
/// An organization device status components power supply poe
/// </summary>
[DataContract]
public class OrganizationDeviceStatusComponentsPowerSupplyPoe
{
	/// <summary>
	/// Maximum PoE this power supply can provide when connected to the current switch model
	/// </summary>
	[DataMember(Name = "maximum")]
	public int? Maximum { get; set; }

	/// <summary>
	/// Unit of the PoE maximum
	/// </summary>
	[DataMember(Name = "unit")]
	public string? Unit { get; set; }
}
