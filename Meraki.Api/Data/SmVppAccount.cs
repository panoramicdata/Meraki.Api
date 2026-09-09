namespace Meraki.Api.Data;

/// <summary>
/// VPP account information
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SmVppAccount
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// VPP service token
	/// </summary>
	[DataMember(Name = "vppServiceToken")]
	public string VppServiceToken { get; set; } = string.Empty;

	/// <summary>
	/// The id of the VPP Account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vppAccountId")]
	public string? VppAccountId { get; set; }

	/// <summary>
	/// The VPP content token
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "contentToken")]
	public string? ContentToken { get; set; }

	/// <summary>
	/// The email address associated with the VPP account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "email")]
	public string? Email { get; set; }

	/// <summary>
	/// The name of the VPP account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The allowed admins for the VPP account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "allowedAdmins")]
	public string? AllowedAdmins { get; set; }

	/// <summary>
	/// The network IDs of the admins for the VPP account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkIdAdmins")]
	public string? NetworkIdAdmins { get; set; }

	/// <summary>
	/// The assignable networks for the VPP account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assignableNetworks")]
	public string? AssignableNetworks { get; set; }

	/// <summary>
	/// The network IDs of the assignable networks for the VPP account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assignableNetworkIds")]
	public List<string> AssignableNetworkIds { get; set; } = [];

	/// <summary>
	/// The VPP location ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vppLocationId")]
	public string? VppLocationId { get; set; }

	/// <summary>
	/// The VPP location name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vppLocationName")]
	public string? VppLocationName { get; set; }

	/// <summary>
	/// The last time the VPP account was synced
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastSyncedAt")]
	public DateTime? LastSyncedAt { get; set; }

	/// <summary>
	/// The last time the VPP account was force synced
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastForceSyncedAt")]
	public DateTime? LastForceSyncedAt { get; set; }

	/// <summary>
	/// The parsed VPP service token
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "parsedToken")]
	public SmVppAccountParsedToken? ParsedToken { get; set; }
}
