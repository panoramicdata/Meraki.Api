namespace Meraki.Api.Data;

/// <summary>
/// Represents a policy which is associated with a network device
/// </summary>
[DataContract]
public class NetworkDevicePolicy
{
	/// <summary>
	/// The unique ID for the policy
	/// </summary>
	[DataMember(Name = "policyId")]
	public int PolicyId { get; set; }

	/// <summary>
	/// The name of the policy
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The priority of the policy
	/// </summary>
	[DataMember(Name = "priority")]
	public int Priority { get; set; }

	/// <summary>
	/// The name of the policy
	/// </summary>
	[DataMember(Name = "isAppliedDirectly")]
	public bool IsAppliedDirectly { get; set; }

	/// <summary>
	/// Specify whether the policy is the default policy
	/// </summary>
	[DataMember(Name = "isDefault")]
	public bool IsDefault { get; set; }

	/// <summary>
	/// The time when the policy was created. Specify an ISO 8601-formatted timestamp
	/// </summary>
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }
}
