namespace Meraki.Api.Data;

/// <summary>
/// Saml
/// </summary>
[DataContract]
public class Saml
{
	/// <summary>
	/// Enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// SP-initiated SSO configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "spInitiated")]
	public SamlSpInitiated? SpInitiated { get; set; }
}
