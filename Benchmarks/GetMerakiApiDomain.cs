using BenchmarkDotNet.Attributes;
using Meraki.Api.Data;
using Meraki.Api.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace Benchmarks;

/// <summary>
/// Benchmarks for GetMerakiApiDomain extension method
/// </summary>
[MemoryDiagnoser]
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Benchmark method names for clarity")]
[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Benchmark methods cannot be static")]
public class GetMerakiApiDomain
{
	[Benchmark]
	public string GetDomain_Default()
		=> ApiRegion.Default.GetMerakiApiDomain();

	[Benchmark]
	public string GetDomain_China()
		=> ApiRegion.China.GetMerakiApiDomain();

	[Benchmark]
	public string GetDomain_Canada()
		=> ApiRegion.Canada.GetMerakiApiDomain();

	[Benchmark]
	public string GetDomain_India()
		=> ApiRegion.India.GetMerakiApiDomain();

	[Benchmark]
	public string GetDomain_Government()
		=> ApiRegion.Government.GetMerakiApiDomain();
}
