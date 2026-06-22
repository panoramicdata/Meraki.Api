using Meraki.Api;

namespace Meraki.Api.Test.EndOfSaleDetails;

/// <summary>
/// Deterministic, offline tests for the Meraki EOL table parser. These exercise the awkward
/// shapes the real page uses (multiple models per row, &lt;br&gt; / "and" / "&amp;" separators,
/// the "-HW" suffix, a model split across adjacent &lt;a&gt; tags, license SKU shorthand,
/// parenthetical qualifiers, descriptive prose and the several date formats) without depending
/// on the network.
/// </summary>
public class ParseEndOfLifeDetailsTests
{
	// A hand-crafted fragment covering the tricky shapes seen on the live page.
	private const string SampleHtml = """
		<table>
			<tbody>
				<tr>
					<th>Product</th><th>Announcement</th><th>End-of-Sale Date</th><th>End-of-Support Date</th>
				</tr>
				<tr>
					<td><a href="https://example.test/mr.html">MR36, MR36H, MR44,<br />MR46, MR46E and Accessories</a></td>
					<td>Jan 27, 2021</td><td>Jul 14, 2022</td><td>Jul 21, 2026</td>
				</tr>
				<tr>
					<td><a href="https://example.test/ms355.html">MS355-48X2-HW,<br />MS355-24X2-HW</a></td>
					<td>Aug 28, 2024</td><td>Aug 8, 2025</td><td>Aug 8 2030</td>
				</tr>
				<tr>
					<td><a href="https://example.test/ant.html">MA-ANT-3-XX Antennas</a><br />(For MR42E, MR53E, MR46E)</td>
					<td>June 03, 2026</td><td>July 22, 2025</td><td>April 30, 2031</td>
				</tr>
				<tr>
					<td><a href="https://example.test/mt.html">MT10-HW, MT11-HW, MT12-HW</a></td>
					<td>Dec 03, 2025</td><td>TBD</td><td></td>
				</tr>
				<tr>
					<td><a href="https://example.test/sm.html">Cisco Meraki Systems Manager</a></td>
					<td>Dec 03, 2025</td><td>June 03, 2026</td><td>June 03, 2029</td>
				</tr>
				<tr>
					<td><a rel="internal" class="ext-pdf" href="https://example.test/mr70.pdf?revision=2">MR70</a><a rel="internal" class="ext-pdf" href="https://example.test/mr70.pdf?revision=2">-HW</a></td>
					<td>Jan 27, 2021</td><td>Jul 21, 2021</td><td>Jul 21, 2026</td>
				</tr>
				<tr>
					<td><a href="https://example.test/insight.pdf">LIC-MI-XS (1D, 1YR, 3YR, 5YR, 7YR, 10YR)</a></td>
					<td>Jan 01, 2024</td><td>Feb 01, 2024</td><td>Mar 01, 2029</td>
				</tr>
				<tr>
					<td><a href="https://example.test/mtlic.pdf">LIC-MT-3Y, 5Y, 7Y, 10Y</a></td>
					<td>Jan 01, 2024</td><td>Feb 01, 2024</td><td>Mar 01, 2029</td>
				</tr>
				<tr>
					<td><a href="https://example.test/gs110.pdf">GS110-8P (UK)</a></td>
					<td>Feb 24, 2023</td><td>Aug 24, 2023</td><td>Aug 24, 2025</td>
				</tr>
				<tr>
					<td><a href="https://example.test/gx50.pdf">GX50-HW-US</a></td>
					<td>Jan 01, 2024</td><td>Feb 01, 2024</td><td>Mar 01, 2029</td>
				</tr>
				<tr>
					<td><a href="https://example.test/mainj.pdf">MA-INJ-4-XX (AU, CN, EU, UK, US)</a></td>
					<td>Oct 29, 2021</td><td>Nov 30, 2021</td><td>Nov 30, 2022</td>
				</tr>
			</tbody>
		</table>
		""";

	private static DateTimeOffset Utc(int year, int month, int day)
		=> new(year, month, day, 0, 0, 0, TimeSpan.Zero);

	[Fact]
	public void Parse_SkipsHeaderRow_AndReturnsOneRecordPerDataRow()
	{
		var details = MerakiClient.ParseEndOfLifeDetails(SampleHtml);

		_ = details.Should().HaveCount(11);
	}

	[Fact]
	public void Parse_MultiModelRow_SplitsModelsKeepsFullTextUrlAndDates()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[0];

		_ = row.DeviceModel.Should().Be("MR36, MR36H, MR44, MR46, MR46E and Accessories");
		_ = row.Models.Should().Equal("MR36", "MR36H", "MR44", "MR46", "MR46E");
		_ = row.EosNoticeUrl.Should().Be("https://example.test/mr.html");
		_ = row.Announcement.Should().Be(Utc(2021, 1, 27));
		_ = row.EndOfSale.Should().Be(Utc(2022, 7, 14));
		_ = row.EndOfSupport.Should().Be(Utc(2026, 7, 21));
		_ = row.Region.Should().BeNull();
		_ = row.Regions.Should().BeEmpty();
	}

	[Fact]
	public void Parse_HardwareSuffixIsPreserved_LineBreaksHandled_AndNoCommaDateParses()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[1];

		// The "-HW" suffix is part of the published model number and is kept.
		_ = row.Models.Should().Equal("MS355-48X2-HW", "MS355-24X2-HW");
		// "Aug 8 2030" has no comma and no leading zero.
		_ = row.EndOfSupport.Should().Be(Utc(2030, 8, 8));
	}

	[Fact]
	public void Parse_ParentheticalQualifierIsExcludedFromModels_AndFullMonthDatesParse()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[2];

		_ = row.Models.Should().Equal("MA-ANT-3-XX");
		// The <br>-to-comma artefact before "(" is tidied away.
		_ = row.DeviceModel.Should().Be("MA-ANT-3-XX Antennas (For MR42E, MR53E, MR46E)");
		_ = row.Announcement.Should().Be(Utc(2026, 6, 3));
		_ = row.EndOfSale.Should().Be(Utc(2025, 7, 22));
		_ = row.EndOfSupport.Should().Be(Utc(2031, 4, 30));
	}

	[Fact]
	public void Parse_MissingOrNonDateCells_YieldNullDates()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[3];

		_ = row.Models.Should().Equal("MT10-HW", "MT11-HW", "MT12-HW");
		_ = row.Announcement.Should().Be(Utc(2025, 12, 3));
		_ = row.EndOfSale.Should().BeNull();   // "TBD"
		_ = row.EndOfSupport.Should().BeNull(); // empty cell
	}

	[Fact]
	public void Parse_DescriptiveOnlyRow_ProducesRecordWithNoModels()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[4];

		_ = row.DeviceModel.Should().Be("Cisco Meraki Systems Manager");
		_ = row.Models.Should().BeEmpty();
		_ = row.EndOfSupport.Should().Be(Utc(2029, 6, 3));
	}

	[Fact]
	public void Parse_ModelSplitAcrossAdjacentTags_IsRejoinedAndUrlDeduplicated()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[5];

		// "<a>MR70</a><a>-HW</a>" must rejoin to the published model "MR70-HW".
		_ = row.DeviceModel.Should().Be("MR70-HW");
		_ = row.Models.Should().Equal("MR70-HW");
		// Both anchors point at the same PDF; the first hyperlink is used.
		_ = row.EosNoticeUrl.Should().Be("https://example.test/mr70.pdf?revision=2");
	}

	[Fact]
	public void Parse_LicenseShorthandWithParenthesisedDurations_ExpandsToFullSkus()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[6];

		_ = row.DeviceModel.Should().Be("LIC-MI-XS (1D, 1YR, 3YR, 5YR, 7YR, 10YR)");
		_ = row.Models.Should().Equal(
			"LIC-MI-XS-1D", "LIC-MI-XS-1YR", "LIC-MI-XS-3YR",
			"LIC-MI-XS-5YR", "LIC-MI-XS-7YR", "LIC-MI-XS-10YR");
	}

	[Fact]
	public void Parse_LicenseShorthandWithCommaContinuations_ExpandsToFullSkus()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[7];

		_ = row.DeviceModel.Should().Be("LIC-MT-3Y, 5Y, 7Y, 10Y");
		_ = row.Models.Should().Equal("LIC-MT-3Y", "LIC-MT-5Y", "LIC-MT-7Y", "LIC-MT-10Y");
	}

	[Fact]
	public void Parse_RegionInParentheses_IsCaptured()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[8];

		_ = row.DeviceModel.Should().Be("GS110-8P (UK)");
		_ = row.Models.Should().Equal("GS110-8P");
		_ = row.Regions.Should().Equal("UK");
	}

	[Fact]
	public void Parse_RegionInSkuSuffix_IsCaptured_AndKeptInTheModel()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[9];

		// The region is part of the published SKU, so it stays in the model identifier...
		_ = row.Models.Should().Equal("GX50-HW-US");
		// ...and is also surfaced as a region.
		_ = row.Regions.Should().Equal("US");
	}

	[Fact]
	public void Parse_MultipleRegions_AreAllCaptured()
	{
		var row = MerakiClient.ParseEndOfLifeDetails(SampleHtml)[10];

		_ = row.Models.Should().Equal("MA-INJ-4-XX");
		_ = row.Regions.Should().Equal("AU", "CN", "EU", "UK", "US");
	}

	[Fact]
	public void Parse_RealMerakiSnapshot_ParsesCleanly()
	{
		var path = Path.Combine(AppContext.BaseDirectory, "EndOfSaleDetails", "meraki-eol-sample.html");
		_ = File.Exists(path).Should().BeTrue($"the EOL HTML fixture must be copied to the test output ({path})");

		var html = File.ReadAllText(path);
		var details = MerakiClient.ParseEndOfLifeDetails(html);

		_ = details.Should().NotBeNullOrEmpty();
		_ = details.Should().HaveCountGreaterThanOrEqualTo(150);

		// Every row yields a product description and a notice URL.
		_ = details.Should().OnlyContain(d => d.DeviceModel.Length > 0);
		_ = details.Should().OnlyContain(d => d.EosNoticeUrl.Length > 0);

		// No <br>-to-comma artefacts leak into the published text.
		_ = details.Should().OnlyContain(d => !d.DeviceModel.Contains(", ("));
		_ = details.Should().OnlyContain(d => !d.DeviceModel.Contains(" and,"));

		// All parsed dates are expressed at UTC offset zero.
		_ = details.Where(d => d.Announcement is not null)
			.Should().OnlyContain(d => d.Announcement!.Value.Offset == TimeSpan.Zero);
		_ = details.Where(d => d.EndOfSale is not null)
			.Should().OnlyContain(d => d.EndOfSale!.Value.Offset == TimeSpan.Zero);
		_ = details.Where(d => d.EndOfSupport is not null)
			.Should().OnlyContain(d => d.EndOfSupport!.Value.Offset == TimeSpan.Zero);

		// The majority of rows expose at least one parsed model identifier.
		_ = details.Count(d => d.Models.Count > 0).Should().BeGreaterThan(details.Count / 2);

		// Spot-check a known single-model row (abbreviated month, comma date). The published
		// model retains its "-HW" suffix.
		var mr56 = details.Should().ContainSingle(d => d.DeviceModel == "MR56-HW").Subject;
		_ = mr56.Models.Should().Equal("MR56-HW");
		_ = mr56.EndOfSale.Should().Be(Utc(2025, 8, 7));
		_ = mr56.EndOfSupport.Should().Be(Utc(2030, 8, 7));

		// Spot-check the no-comma date variant ("Aug 8 2030") on a real row.
		var ms350 = details.Should().ContainSingle(d => d.DeviceModel == "MS350-24X-HW").Subject;
		_ = ms350.Models.Should().Equal("MS350-24X-HW");
		_ = ms350.EndOfSupport.Should().Be(Utc(2030, 8, 8));

		// Spot-check real license shorthand expansion (parenthesised duration list).
		var insight = details.Should().ContainSingle(d => d.DeviceModel == "LIC-MI-XS (1D, 1YR, 3YR, 5YR, 7YR, 10YR)").Subject;
		_ = insight.Models.Should().Equal(
			"LIC-MI-XS-1D", "LIC-MI-XS-1YR", "LIC-MI-XS-3YR",
			"LIC-MI-XS-5YR", "LIC-MI-XS-7YR", "LIC-MI-XS-10YR");

		// Spot-check real license shorthand expansion (comma continuations).
		var mtLicense = details.Should().ContainSingle(d => d.DeviceModel == "LIC-MT-3Y, 5Y, 7Y, 10Y").Subject;
		_ = mtLicense.Models.Should().Equal("LIC-MT-3Y", "LIC-MT-5Y", "LIC-MT-7Y", "LIC-MT-10Y");

		// Spot-check real region parsing: parenthetical, SKU suffix, and multi-region.
		var gs110uk = details.Should().ContainSingle(d => d.DeviceModel == "GS110-8P (UK)").Subject;
		_ = gs110uk.Models.Should().Equal("GS110-8P");
		_ = gs110uk.Regions.Should().Equal("UK");

		var gx50us = details.Should().ContainSingle(d => d.DeviceModel == "GX50-HW-US").Subject;
		_ = gx50us.Regions.Should().Equal("US");

		var maInj = details.Should().ContainSingle(d => d.DeviceModel == "MA-INJ-4-XX (AU, CN, EU, UK, US)").Subject;
		_ = maInj.Regions.Should().Equal("AU", "CN", "EU", "UK", "US");
	}
}
