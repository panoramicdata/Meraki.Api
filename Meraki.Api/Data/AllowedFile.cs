using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// AllowedFile
/// </summary>
[DataContract]
public class AllowedFile
{
	/// <summary>
	/// The file sha256 hash to whitelist
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sha256")]
	public string Sha256 { get; set; } = string.Empty;

	/// <summary>
	/// Comment about the whitelisted entity
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
