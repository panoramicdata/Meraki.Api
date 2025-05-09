namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationsMetadata
{
	/// <summary>
	/// Total count of Private Applications
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}