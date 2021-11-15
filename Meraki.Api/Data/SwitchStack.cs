using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// A switch stack
/// </summary>
[DataContract]
public class SwitchStack : NamedIdentifiedItem
{
	public const int MaxNameLength = 38;

	/// <summary>
	/// Serials
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = new List<string>();
}
