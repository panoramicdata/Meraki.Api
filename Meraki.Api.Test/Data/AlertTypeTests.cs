using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

public class AlertTypeTests
{
	[Fact]
	public void DeserializeAlertType_NatDetection_Succeeds()
	{
		var settings = new JsonSerializerSettings
		{
			Converters = [new StringEnumConverter()]
		};

		var alertType = JsonConvert.DeserializeObject<AlertType>("\"natDetection\"", settings);

		_ = alertType.Should().Be(AlertType.NatDetection);
	}
}
