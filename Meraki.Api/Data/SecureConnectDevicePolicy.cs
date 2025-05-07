namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDevicePolicy
/// </summary>
[DataContract]
public class SecureConnectDevicePolicy
{
	/// <summary>
	/// The unique ID for the policy.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "policyId")]
	public int? PolicyId { get; set; }

	/// <summary>
	/// The priority of the policy.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "priority")]
	public int? Priority { get; set; }

	/// <summary>
	/// The time when the policy was created. Specify an ISO 8601-formatted timestamp.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// The name of the policy.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "deviceId")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Specify whether the policy is directly applied to this network device.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isAppliedDirectly")]
	public bool IsAppliedDirectly { get; set; }

	/// <summary>
	/// Specify whether the policy is the default policy.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isDefault")]
	public bool IsDSefault { get; set; }
}
