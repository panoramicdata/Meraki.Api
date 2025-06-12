namespace Meraki.Api.Data;

/// <summary>
/// Certificate Hash Information
/// </summary>
[DataContract]
public class OrganizationCertificatesFieldsHash
{
	/// <summary>
	/// Hash Algorithm of one of Certificate's hashes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "algorithm")]
	public string Algorithm { get; set; } = string.Empty;

	/// <summary>
	/// Certificate's Hash Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hash")]
	public string Hash { get; set; } = string.Empty;
}