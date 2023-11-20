namespace Meraki.Api.Data;

/// <summary>
/// An organization device status components
/// </summary>
[DataContract]
public class OrganizationDeviceStatusComponents
{
	/// <summary>
	/// Power Supplies
	/// </summary>
	[DataMember(Name = "powerSupplies")]
	public List<OrganizationDeviceStatusComponentsPowerSupply>? PowerSupplies { get; set; }
}
