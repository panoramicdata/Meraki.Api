namespace Meraki.Api.Data;

/// <summary>
/// Authentication details 
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryItemAuthentication
{
	/// <summary>
	/// Authentication Protocol
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;
}