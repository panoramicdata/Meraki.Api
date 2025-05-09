namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Applications
/// </summary>
[DataContract]
public class SecureConnectPrivateApplications
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SecureConnectPrivateApplicationsMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Private Applications
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<SecureConnectPrivateApplication> Data { get; set; } = [];
}
