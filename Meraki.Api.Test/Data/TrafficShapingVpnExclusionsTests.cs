using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// A custom VPN exclusion rule with a VLAN source is returned with "source" as an object,
/// which failed the whole byNetwork response when Source was typed as a string.
/// </summary>
public class TrafficShapingVpnExclusionsTests
{
	private const string VlanSourceJson = "{\"items\":[{\"networkId\":\"L_1\",\"networkName\":\"Net\",\"custom\":[{\"protocol\":\"any\",\"destination\":\"0.0.0.0/0\",\"port\":\"any\",\"source\":{\"vlanId\":\"920\",\"port\":\"any\"}}],\"majorApplications\":[],\"applications\":[]}]}";

	[Fact]
	public void DeserializeByNetwork_VlanSource_Succeeds()
	{
		var response = JsonConvert.DeserializeObject<TrafficShapingVpnExclusionsByNetworkResponse>(VlanSourceJson);

		var source = response!.Items![0].Custom![0].Source;
		_ = source.Should().NotBeNull();
		_ = source!.VlanId.Should().Be("920");
		_ = source.Port.Should().Be("any");
	}

	[Fact]
	public void DeserializeCustom_NullSource_Succeeds()
	{
		var custom = JsonConvert.DeserializeObject<TrafficShapingVpnExclusionsCustom>("{\"protocol\":\"any\",\"destination\":\"10.0.0.0/8\",\"port\":\"any\",\"source\":null}");

		_ = custom!.Source.Should().BeNull();
	}

	[Fact]
	public void DeserializeApplication_VlanSource_Succeeds()
	{
		var application = JsonConvert.DeserializeObject<TrafficShapingVpnExclusionsApplication>("{\"id\":\"meraki:layer7/application/1431\",\"name\":\"Microsoft Office 365\",\"protocol\":\"any\",\"source\":{\"vlanId\":\"920\",\"port\":\"any\"}}");

		_ = application!.Source!.VlanId.Should().Be("920");
	}

	[Fact]
	public void SerializeCustom_VlanSource_RoundTripsAsObject()
	{
		var custom = new TrafficShapingVpnExclusionsCustom
		{
			Destination = "0.0.0.0/0",
			Port = "any",
			Source = new TrafficShapingVpnExclusionsCustomSource { VlanId = "920", Port = "any" }
		};

		var json = JsonConvert.SerializeObject(custom);

		_ = json.Should().Contain("\"source\":{\"vlanId\":\"920\",\"port\":\"any\"}");
	}
}
