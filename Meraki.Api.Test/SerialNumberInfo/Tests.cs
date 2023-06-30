namespace Meraki.Api.Test.SerialNumberInfo;

public class Tests : MerakiClientTest
{
	private const string SerialNumber = "Q2AT-1234-1234";

	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public void GetFromSerialNumber()
	{
		var result = MerakiClient.GetInfoFromSerialNumber(SerialNumber);
		_ = result.SerialNumber.Should().Be(SerialNumber);
		_ = result.Model.Should().Be("MC74");
		_ = result.ProductType.Should().Be(ProductType.Phone);
		_ = result.IsVirtual.Should().BeFalse();
	}
}
