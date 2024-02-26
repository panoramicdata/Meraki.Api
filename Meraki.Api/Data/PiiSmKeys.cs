namespace Meraki.Api.Data;

/// <summary>
/// Pii SM key response
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class PiiSmKeys : Dictionary<string, List<string>>;
