namespace Meraki.Api.Test.Networks.Webhooks;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllPayloadTemplatesAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync()
			.ConfigureAwait(false);

		var result = await TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.GetNetworkWebhooksPayloadTemplatesAsync(network.Id)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<List<PayloadTemplate>>();
		_ = result.Should().NotBeNull();
	}
}
