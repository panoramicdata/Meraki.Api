using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

public class Md5AuthenticationKey
{
	/// <summary>
	/// MD5 authentication key index. Key index must be between 1 to 255
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public int Id { get; set; }

	/// <summary>
	/// MD5 authentication passphrase
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "passphrase")]
	public string Passphrase { get; set; } = string.Empty;
}
