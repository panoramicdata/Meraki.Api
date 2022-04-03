namespace Meraki.Api.Data;

/// <summary>
/// The adaptive policy group (requires one unique attribute)
/// </summary>
[DataContract]
public class AdaptivePolicyPoliciesGroup
{
	/// <summary>
	/// The ID of the source/destination adaptive policy group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the source/destination adaptive policy group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The SGT of the source/destination adaptive policy group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sgt")]
	public int Sgt { get; set; }
}
