namespace Meraki.Api.Data;

/// <summary>
/// Certificate's key usage
/// </summary>
[DataContract]
public class OrganizationCertificatesFieldsKeyUsage
{
	/// <summary>
	/// Is key usage critical
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isCritical")]
	public bool IsCritical { get; set; }

	/// <summary>
	/// Key usage data
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "data")]
	public List<string> Data { get; set; } = [];
}