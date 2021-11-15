namespace Meraki.Api.Data;

/// <summary>
/// List the keys required to access Personally Identifiable Information (PII) for a given identifier. Exactly one identifier will be accepted. If the organization contains org-wide Systems Manager users matching the key provided then there will be an entry with the key "0" containing the applicable keys.
/// </summary>
[DataContract]
public class PiiKeys : Dictionary<string, PiiKey>
{
}
