namespace Meraki.Api.Data;

/// <summary>
/// SSID encryption settings
/// </summary>
[DataContract]
public class SsidSecurityEncryption
{
    /// <summary>
    /// Cipher suites advertised for the SSID
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "ciphers")]
    public List<string>? Ciphers { get; set; }

    /// <summary>
    /// AKM suites advertised for the SSID
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "akms")]
    public List<string>? Akms { get; set; }
}
