namespace Meraki.Api.Data;

/// <summary>
/// Validity dates of Certificate
/// </summary>
[DataContract]
public class OrganizationCertificatesFieldsValidity
{
	/// <summary>
	/// End date of Certificate Validity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "end")]
	public string End { get; set; } = string.Empty;

	/// <summary>
	/// Start date of Certificate Validity
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "start")]
	public string Start { get; set; } = string.Empty;
}