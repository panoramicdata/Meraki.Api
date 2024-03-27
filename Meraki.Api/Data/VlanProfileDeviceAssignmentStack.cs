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
	/// While this is not strictly a foreign key it is useful for comparing historical entries where the switch stack id may have changed.
	[ApiForeignKey(typeof(SwitchStack))]
	[ApiAccess(ApiAccess.Read)
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}