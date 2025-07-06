namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Mirrors By Device Response
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByDeviceResponse
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsMirrorsByDeviceResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of port mirror configurations in an organization by switch
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsMirrorConfiguration> Items { get; set; } = [];
}
