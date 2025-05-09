namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Application Create Request
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationCreateRequest
{
	/// <summary>
	/// Protocol for communication between proxy to private application. Applicable for Browser Based Access only.
	/// </summary>
	[DataMember(Name = "appProtocol")]
	public string? AppProtocol { get; set; }

	/// <summary>
	/// Optional Text description for Application
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Cisco or Customer Managed URL for Application. Applicable for Browser Based Access only. This field is system generated based on the application name and organization ID and overrides user input in payload. This value must be unique across all applications for a given organization.
	/// </summary>
	[DataMember(Name = "externalFQDN")]
	public string? ExternalFQDN { get; set; }

	/// <summary>
	/// Name of Application. This is required and should be unique across all applications for a given organization. Name cannot have any special characters other than spaces and hyphens.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Optional SNI. Applicable for Browser Based Access only. SNI should be a valid domain.
	/// </summary>
	[DataMember(Name = "sni")]
	public string? Sni { get; set; }

	/// <summary>
	/// Enable Upstream SSL verification for the internally hosted URL by the customer. Applicable for Browser Based Access only. Default is true.
	/// </summary>
	[DataMember(Name = "sslVerificationEnabled")]
	public bool? SslVerificationEnabled { get; set; }

	/// <summary>
	/// List of application group ids attached to this Private Application
	/// </summary>
	[DataMember(Name = "applicationGroupIds")]
	public List<string>? ApplicationGroupIds { get; set; }

	/// <summary>
	/// List of IP address destinations.
	/// </summary>
	[DataMember(Name = "destinations")]
	public List<SecureConnectPrivateApplicationDestination> Destinations { get; set; } = [];
}
