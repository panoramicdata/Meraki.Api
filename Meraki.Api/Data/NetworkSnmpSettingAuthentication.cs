namespace Meraki.Api.Data;

/// <summary>
/// SNMP authentication settings
/// </summary>
[DataContract]
public class NetworkSnmpSettingAuthentication
{
    /// <summary>
    /// The SNMP authentication protocol
    /// </summary>
    [ApiAccess(ApiAccess.ReadUpdate)]
    [DataMember(Name = "protocol")]
    public string? Protocol { get; set; }
}
