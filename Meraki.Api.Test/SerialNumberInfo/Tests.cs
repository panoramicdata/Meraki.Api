namespace Meraki.Api.Test.SerialNumberInfo;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Theory]
	[InlineData("Q2AT-1234-1234", "MC74", ProductType.Phone, false)]
	[InlineData("Q5AC-1234-1234", "CW9164I", ProductType.Wireless, false)]
	public void GetFromSerialNumber(string serialNumber, string productName, ProductType productType, bool isVirtual)
	{
		var result = MerakiClient.GetInfoFromSerialNumber(serialNumber);
		_ = result.SerialNumber.Should().Be(serialNumber);
		_ = result.Model.Should().Be(productName);
		_ = result.ProductType.Should().Be(productType);
		_ = result.IsVirtual.Should().Be(isVirtual);
	}
}
