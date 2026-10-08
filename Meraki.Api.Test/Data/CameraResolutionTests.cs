using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Resolutions the live API returns that were missing from the enums, which made the
/// whole response fail to deserialize.
/// </summary>
public class CameraResolutionTests
{
	[Fact]
	public void DeserializeCameraQualityAndRetention_3840x2160_Succeeds()
	{
		var qualityAndRetention = JsonConvert.DeserializeObject<CameraQualityAndRetention>("{\"resolution\":\"3840x2160\"}");

		_ = qualityAndRetention!.Resolution.Should().Be(Resolution.Size3840x2160);
	}

	[Fact]
	public void DeserializeMv44X_1440x1080_Succeeds()
	{
		var mv44X = JsonConvert.DeserializeObject<Mv44X>("{\"quality\":\"Standard\",\"resolution\":\"1440x1080\"}");

		_ = mv44X!.Resolution.Should().Be(Mv44xResolution.Size1440x1080);
	}
}
