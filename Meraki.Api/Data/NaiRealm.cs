namespace Meraki.Api.Data;

/// <summary>
/// Nai realms
/// </summary>
public class NaiRealm
{
	/// <summary>
	/// The format for the realm ('1' or '0')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "format")]
	public int Format { get; set; }

	/// <summary>
	/// The name of the realm
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "realm")]
	public string Realm { get; set; } = string.Empty;

	/// <summary>
	/// Methods
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "methods")]
	public List<EapMethod> Methods { get; set; } = [];
}
