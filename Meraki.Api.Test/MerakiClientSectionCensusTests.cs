using System.Reflection;

namespace Meraki.Api.Test;

/// <summary>
/// Walks the whole section tree of a freshly constructed <see cref="MerakiClient"/> and fails if
/// any section or Refit client is left null
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/357">issue 357</see>).
/// The constructor is a hand-maintained mirror of the section tree, and a missing entry compiles
/// cleanly because every property is declared <c>= null!</c>; this is the check that catches the
/// drift. No credentials or network are needed.
/// </summary>
public class MerakiClientSectionCensusTests
{
	private const string SectionsNamespace = "Meraki.Api.Sections";
	private const string InterfacesNamespace = "Meraki.Api.Interfaces";

	private static MerakiClient CreateClient()
		=> new(new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0"
		});

	[Fact]
	public void Constructor_LeavesNoSectionOrRefitClientNull()
	{
		using var client = CreateClient();

		var nulls = new List<string>();
		var visited = new HashSet<object>(ReferenceEqualityComparer.Instance);
		Walk(client, "client", nulls, visited);

		_ = nulls.Should().BeEmpty("every section and Refit client should be assigned by the constructor, but these were null:\n  {0}", string.Join("\n  ", nulls));
	}

	[Fact]
	public void EveryRefitInterface_CanBeConstructed()
	{
		// The single-argument RestService.For<T>(HttpClient) overload, chosen deliberately: the
		// (HttpClient, IRequestBuilder<T>) overload with a null builder constructs anything.
		var forMethod = typeof(RestService)
			.GetMethods(BindingFlags.Public | BindingFlags.Static)
			.Single(m => m.Name == nameof(RestService.For)
				&& m.IsGenericMethodDefinition
				&& m.GetParameters() is [{ ParameterType: var p }] && p == typeof(HttpClient));
		using var httpClient = new HttpClient { BaseAddress = new Uri("https://api.meraki.com/api/v1") };

		var failures = new List<string>();
		foreach (var type in RefitInterfaces())
		{
			try
			{
				_ = forMethod.MakeGenericMethod(type).Invoke(null, [httpClient]);
			}
			catch (TargetInvocationException ex)
			{
				failures.Add($"{type.Name}: {ex.InnerException?.Message}");
			}
		}

		_ = failures.Should().BeEmpty("every Refit interface should build, but these did not:\n  {0}", string.Join("\n  ", failures));
	}

	/// <summary>
	/// Every interface under Meraki.Api.Interfaces that carries at least one Refit HTTP method
	/// attribute. Interfaces without one (for example IRateLimiter) are not Refit clients.
	/// </summary>
	private static IEnumerable<Type> RefitInterfaces()
		=> typeof(MerakiClient).Assembly
			.GetTypes()
			.Where(t => t.IsInterface
				&& t.Namespace?.StartsWith(InterfacesNamespace, StringComparison.Ordinal) == true
				&& IsRefitClient(t));

	private static bool IsRefitClient(Type type)
		=> type.GetMethods().Any(m => m.GetCustomAttributes(true).OfType<HttpMethodAttribute>().Any());

	private static void Walk(object node, string path, List<string> nulls, HashSet<object> visited)
	{
		if (!visited.Add(node))
		{
			return;
		}

		var properties = node
			.GetType()
			.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
			.Where(p => p.GetIndexParameters().Length == 0);

		foreach (var property in properties)
		{
			var type = property.PropertyType;
			var isSection = IsSection(type);
			if (!isSection && !IsRefitClientProperty(type))
			{
				continue;
			}

			var value = property.GetValue(node);
			var childPath = $"{path}.{property.Name}";
			if (value is null)
			{
				nulls.Add($"{childPath} ({type.Name})");
			}
			else if (isSection)
			{
				Walk(value, childPath, nulls, visited);
			}
		}
	}

	private static bool IsSection(Type type)
		=> type.IsClass && type.Namespace?.StartsWith(SectionsNamespace, StringComparison.Ordinal) == true;

	private static bool IsRefitClientProperty(Type type)
		=> type.IsInterface
			&& type.Namespace?.StartsWith(InterfacesNamespace, StringComparison.Ordinal) == true
			&& IsRefitClient(type);
}
