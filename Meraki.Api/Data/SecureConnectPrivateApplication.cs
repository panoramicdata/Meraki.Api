namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Application
/// </summary>
[DataContract]
public class SecureConnectPrivateApplication
{
	/// <summary>
	/// Protocol for communication between proxy to private application. Applicable for Browser Based Access only.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "appProtocol")]
	public string AppProtocol { get; set; } = string.Empty;

	/// <summary>
	/// Private Application resource ID, use this ID as reference for subsequent requests
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "applicationId")]
	public string ApplicationId { get; set; } = string.Empty;

	/// <summary>
	/// Creation time of the private app
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Optional Text description for Application
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Cisco or Customer Managed URL for Application. Applicable for Browser Based Access only. This field is system generated based on the application name and organization ID and overrides user input in payload. This value must be unique across all applications for a given organization.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "externalFQDN")]
	public string ExternalFQDN { get; set; } = string.Empty;

	/// <summary>
	/// Last modified time of the private app
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modifiedAt")]
	public string ModifiedAt { get; set; } = string.Empty;

	/// <summary>
	/// Name of Application. This is required and should be unique across all applications for a given organization. Name cannot have any special characters other than spaces and hyphens.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Optional SNI. Applicable for Browser Based Access only. SNI should be a valid domain.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sni")]
	public string? Sni { get; set; }

	/// <summary>
	/// Enable Upstream SSL verification for the internally hosted URL by the customer. Applicable for Browser Based Access only. Default is true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sslVerificationEnabled")]
	public bool SslVerificationEnabled { get; set; }

	/// <summary>
	/// List of application group ids attached to this Private Application
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "applicationGroupIds")]
	public List<string> ApplicationGroupIds { get; set; } = [];

	/// <summary>
	/// Destination targets for Private Applications.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destinations")]
	public List<SecureConnectPrivateApplicationDestination> Destinations { get; set; } = [];
}
