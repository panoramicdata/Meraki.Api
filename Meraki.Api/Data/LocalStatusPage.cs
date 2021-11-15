using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Local Status Page
/// </summary>
[DataContract]
public class LocalStatusPage
{
	/// <summary>
	/// Authentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authentication")]
	public StatusPageAuthentication Authentication { get; set; } = new();
}
