using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// An identified item
/// </summary>
[DataContract]
public abstract class IdentifiedItem
{
	/// <summary>
	/// The Id
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	public string Id { get; set; } = string.Empty;
}
