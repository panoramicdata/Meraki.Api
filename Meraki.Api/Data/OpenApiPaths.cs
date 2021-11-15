using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Open API paths
/// </summary>
[DataContract]
public class OpenApiPaths
{
	/// <summary>
	/// /organizations
	/// </summary>
	[DataMember(Name = "/organizations")]
	public SlashOrganizations Organizations { get; set; } = new();
}
