namespace Meraki.Api.Data;

/// <summary>
/// SM Users
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]

public class SmNetworkUser
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Email
	/// </summary>
	[DataMember(Name = "email")]
	public string? Email { get; set; }

	/// <summary>
	/// Full name
	/// </summary>
	[DataMember(Name = "fullName")]
	public string? FullName { get; set; }

	/// <summary>
	/// Username
	/// </summary>
	[DataMember(Name = "username")]
	public string Username { get; set; } = string.Empty;

	/// <summary>
	/// Has password
	/// </summary>
	[DataMember(Name = "hasPassword")]
	public bool HasPassword { get; set; }

	/// <summary>
	/// Tags
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Ad groups
	/// </summary>
	[DataMember(Name = "adGroups")]
	public List<string> AdGroups { get; set; } = [];

	/// <summary>
	/// Azure ad groups
	/// </summary>
	[DataMember(Name = "azureAdGroups")]
	public List<string> AzureAdGroups { get; set; } = [];

	/// <summary>
	/// Saml groups
	/// </summary>
	[DataMember(Name = "samlGroups")]
	public List<string> SamlGroups { get; set; } = [];

	/// <summary>
	/// Asm groups
	/// </summary>
	[DataMember(Name = "asmGroups")]
	public List<string> AsmGroups { get; set; } = [];

	/// <summary>
	/// Is external
	/// </summary>
	[DataMember(Name = "isExternal")]
	public bool IsExternal { get; set; }

	/// <summary>
	/// Display name
	/// </summary>
	[DataMember(Name = "displayName")]
	public string DisplayName { get; set; } = string.Empty;

	/// <summary>
	/// Has identity certificate
	/// </summary>
	[DataMember(Name = "hasIdentityCertificate")]
	public bool HasIdentityCertificate { get; set; }

	/// <summary>
	/// User thumbnail
	/// </summary>
	[DataMember(Name = "userThumbnail")]
	public string? UserThumbnail { get; set; }
}
