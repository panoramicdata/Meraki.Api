namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV44X camera models.
/// </summary>
[DataContract]
public class Mv44X
{
    /// <summary>
    /// Gets or Sets Quality
    /// </summary>
    [ApiAccess(ApiAccess.ReadWrite)]
    [DataMember(Name = "quality")]
    public StandardEnhancedHighQuality Quality { get; set; }

    /// <summary>
    /// Gets or Sets Resolution
    /// </summary>
    [ApiAccess(ApiAccess.ReadWrite)]
    [DataMember(Name = "resolution")]
    public Mv44xResolution Resolution { get; set; }
}
