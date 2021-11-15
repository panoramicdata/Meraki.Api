using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV32 camera models.
/// </summary>
[DataContract]
public class Mv32
{
	/// <summary>
	/// Gets or Sets Quality
	/// </summary>
	[DataMember(Name = "quality")]
	public StandardEnhancedQuality Quality { get; set; }

	/// <summary>
	/// Gets or Sets Resolution
	/// </summary>
	[DataMember(Name = "resolution")]
	public Mv32Resolution Resolution { get; set; }
}
