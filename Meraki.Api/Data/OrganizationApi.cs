namespace Meraki.Api.Data;

/// <summary>
/// Organization Api
/// </summary>
[DataContract]
public class OrganizationApi
{
	/// <summary>
	/// If true, enable the access to the Cisco Meraki Dashboard API
	/// </summary>
	[DataMember(Name = "enabled")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public bool Enabled { get; set; }
}
