using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// A model to Create or Update MerakiAuthUser
/// </summary>
[DataContract]
public class MerakiAuthUserCreateUpdateRequest : MerakiAuthUser
{
	/// <summary>
	/// The password for this user account
	/// </summary>
	[ApiAccess(ApiAccess.CreateUpdate)]
	[DataMember(Name = "password")]
	public string Password { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not Meraki should email the password to user. Default is false.
	/// </summary>
	[ApiAccess(ApiAccess.CreateUpdate)]
	[DataMember(Name = "emailPasswordToUser")]
	public bool EmailPasswordToUser { get; set; }
}
