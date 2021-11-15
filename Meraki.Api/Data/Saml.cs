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
}
