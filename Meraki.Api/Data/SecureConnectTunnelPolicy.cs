namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelPolicy
/// </summary>
[DataContract]
public class SecureConnectTunnelPolicy
{
	/// <summary>
	/// The resource ID. Use the ID as reference for subsequent requests.
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public int? Id { get; set; }

	/// <summary>
	/// The organization ID.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public int? OrganizationId { get; set; }

	/// <summary>
	/// An integer that represents the position of the policy in the policy list.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "priority")]
	public int Priority { get; set; }

	/// <summary>
	/// The date and time (timestamp) when the tunnel was created.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// The date and time (timestamp) that Umbrella updated the tag on the roaming computer.
	/// The timestamp is an ISO 8601 formatted string. For example: 2023-04-12T23:20:50.52Z.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modifiedAt")]
	public DateTime ModifiedAt { get; set; }

	/// <summary>
	/// The name of the policy.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The type of policy. enum = ["firewallrule", "web"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Resource URI
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uri")]
	public string Uri { get; set; } = string.Empty;

	/// <summary>
	/// True if the tunnel is applied directly to this policy, false if the policy is configured to use all tunnels.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAppliedDirectly")]
	public bool IsAppliedDirectly { get; set; }

	/// <summary>
	/// Indicates whether the policy is the default policy.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isDefault")]
	public bool IsDefault { get; set; }
}
