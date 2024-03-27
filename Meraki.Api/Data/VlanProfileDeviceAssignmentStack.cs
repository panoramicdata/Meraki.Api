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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Switch Stack - Undocumented but is returned by the API
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}