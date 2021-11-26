namespace Meraki.Api.Data;

/// <summary>
/// Methods
/// </summary>
[DataContract]
public class EapMethod : IdentifiedItem
{
	/// <summary>
	/// Authentication types
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authenticationTypes")]
	public AuthenticationTypes AuthenticationTypes { get; set; } = new();
}
