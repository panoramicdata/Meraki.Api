namespace Meraki.Api.Test.SerialNumberInfo;

public class Tests()
{
	[Theory]
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant
	[InlineData("Q2AT-1234-1234", "MC74", ProductType.Phone, false)]
	[InlineData("Q5AC-1234-1234", "CW9164I", ProductType.Wireless, false)]
#pragma warning restore CS3016 // Arrays as attribute arguments is not CLS-compliant
	public void GetFromSerialNumber(string serialNumber, string productName, ProductType productType, bool isVirtual)
	{
		var result = MerakiClient.GetInfoFromSerialNumber(serialNumber);
		_ = result.SerialNumber.Should().Be(serialNumber);
		_ = result.Model.Should().Be(productName);
		_ = result.ProductType.Should().Be(productType);
		_ = result.IsVirtual.Should().Be(isVirtual);

		if (result.EndOfSale is not null)
		{
			_ = result.EndOfSale.Value.Offset.Should().Be(TimeSpan.Zero);
			_ = result.EndOfSupport.Should().NotBeNull();
			_ = result.EndOfSaleNoticeUrl.Should().NotBeNull();
		}
	}
}