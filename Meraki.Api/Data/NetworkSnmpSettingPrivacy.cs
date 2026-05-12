namespace Meraki.Api.Data;

/// <summary>
/// SNMP privacy settings
/// </summary>
[DataContract]
public class NetworkSnmpSettingPrivacy
{
    /// <summary>
    /// The SNMP privacy protocol
    /// </summary>
    [ApiAccess(ApiAccess.ReadUpdate)]
    [DataMember(Name = "protocol")]
    public string? Protocol { get; set; }
}
