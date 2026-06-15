using Meraki.Api;

namespace Meraki.Api.Test.EndOfSaleDetails;

/// <summary>
/// Live smoke test that fetches the published Meraki EOL page. It exists to detect when
/// Meraki change the page structure (which would silently break parsing). Deterministic
/// parsing behaviour is covered offline by <see cref="ParseEndOfLifeDetailsTests"/>.
/// </summary>
public class Tests
{
	[Fact]
	public async Task GetEndOfLifeDetailsAsync_ParsesLivePage()
	{
		var details = await MerakiClient
			.GetEndOfLifeDetailsAsync(TestContext.Current.CancellationToken);

		_ = details.Should().NotBeNullOrEmpty();

		// Every row should yield a product description and a notice URL.
		_ = details.Should().OnlyContain(d => d.DeviceModel.Length > 0);
		_ = details.Should().OnlyContain(d => d.EosNoticeUrl.Length > 0);

		// The page should still contain recognisable device models.
		_ = details.Should().Contain(d => d.Models.Count > 0);

		// Any parsed dates should be expressed at UTC offset zero.
		_ = details
			.Where(d => d.EndOfSale is not null)
			.Should()
			.OnlyContain(d => d.EndOfSale!.Value.Offset == TimeSpan.Zero);
	}
}
