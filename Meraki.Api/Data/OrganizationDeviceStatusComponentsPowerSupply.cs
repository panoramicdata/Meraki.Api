namespace Meraki.Api.Data;

/// <summary>
/// An organization device status components power supply
/// </summary>
[DataContract]
public class OrganizationDeviceStatusComponentsPowerSupply
{
	/// <summary>
	/// Slot the power supply is in
	/// </summary>
	[DataMember(Name = "slot")]
	public int? Slot { get; set; }

	/// <summary>
	/// Model of the power supply
	/// </summary>
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// Serial of the power supply
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Status of the power supply
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// PoE info of the power supply
	/// </summary>
	[DataMember(Name = "poe")]
	public OrganizationDeviceStatusComponentsPowerSupplyPoe? Poe { get; set; }
}
