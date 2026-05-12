namespace Meraki.Api.Data;

/// <summary>
/// VLAN VRF settings
/// </summary>
[DataContract]
public class VlanVrf
{
    /// <summary>
    /// The id of the VRF this VLAN belongs to
    /// </summary>
    [ApiKey]
    [DataMember(Name = "id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// The name of the VRF this VLAN belongs to
    /// </summary>
    [DataMember(Name = "name")]
    public string Name { get; set; } = string.Empty;
}
