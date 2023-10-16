namespace Meraki.Api.Data;
/// <summary>
///  The Switch Stack the device belongs to
/// </summary>
public class VlanProfileDeviceAssignmentStack
{
	/// <summary>
	/// ID of the Switch Stack
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}