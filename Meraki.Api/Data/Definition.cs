namespace Meraki.Api.Data;

/// <summary>
/// Definition
/// </summary>
[DataContract]
public class Definition
{
	/// <summary>
	/// The type of definition. Can be one of 'application', 'applicationCategory', 'host', 'port', 'ipRange' or 'localNet'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public DefinitionType Type { get; set; }

	/// <summary>
	/// If "type" is 'host', 'port', 'ipRange' or 'localNet', then "value" must be a string, matching either a hostname (e.g. "somesite.com"), a port (e.g. 8080), or an IP range ("192.1.0.0", "192.1.0.0/16", or "10.1.0.0/16:80"). 'localNet' also supports CIDR notation, excluding custom ports. If "type" is 'application' or 'applicationCategory', then "value" must be an object with the structure { "id": "meraki:layer7/..." }, where "id" is the application category or application ID (for a list of IDs for your network, use the trafficShaping/applicationCategories endpoint).
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}
