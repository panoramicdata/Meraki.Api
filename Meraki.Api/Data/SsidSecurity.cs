namespace Meraki.Api.Data;

/// <summary>
/// Security settings for an SSID
/// </summary>
[DataContract]
public class SsidSecurity
{
    /// <summary>
    /// Encryption settings for the SSID
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "encryption")]
    public SsidSecurityEncryption? Encryption { get; set; }
}
