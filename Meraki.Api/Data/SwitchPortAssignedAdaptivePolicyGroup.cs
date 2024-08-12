namespace Meraki.Api.Data;

/// <summary>
/// An asaptive policy group assigned to a Port
/// </summary>
[DataContract]
public class SwitchPortAssignedAdaptivePolicyGroup
{
	/// <summary>
	/// The ID of the adaptive policy group.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the adaptive policy group.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
