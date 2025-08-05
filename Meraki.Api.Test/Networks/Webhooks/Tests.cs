namespace Meraki.Api.Test.Networks.Webhooks;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetAllPayloadTemplatesAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.GetNetworkWebhooksPayloadTemplatesAsync(network.Id, cancellationToken: CancellationToken);
		_ = result.Should().BeOfType<List<PayloadTemplate>>();
		_ = result.Should().NotBeNull();
	}
}
