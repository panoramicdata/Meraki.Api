namespace Meraki.Api.Data;

/// <summary>
/// Organization Certificates Import Request
/// </summary>
[DataContract]
public class OrganizationCertificatesImportRequest
{
	/// <summary>
	/// Certificate content in Base64 encoded string format
	/// </summary>
	[DataMember(Name = "contents")]
	public string Contents { get; set; } = string.Empty;

	/// <summary>
	/// Certificate description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Certificate managed by type [system_manager, mr, encrypted_syslog] enum = ["encrypted_syslog", "mr", "system_manager"]
	/// </summary>
	[DataMember(Name = "managedBy")]
	public string ManagedBy { get; set; } = string.Empty;
}
