namespace Meraki.Api.Data;
/// <summary>
///  The Switch Stack the device belongs to
/// </summary>
[DataContract]
public class VlanProfileDeviceAssignmentStack
{
	/// <summary>
	/// ID of the Switch Stack
	/// </summary>
	[ApiForeignKey(typeof(SwitchStack))]
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Switch Stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}