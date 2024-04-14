using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using RefitClassSourceGenerator;
using System.Collections.Immutable;

namespace TestConsoleApp;

static class Program
{
	static void Main()
	{
		var source =

			@"
using System;
using System.Threading;
using System.Threading.Tasks;
using Meraki.Api.Interfaces.General.Networks;

namespace Meraki.Api.Interfaces.General.Networks {
	public interface INetworks
	{
		Task<string> GetNetworkAsync(string networkId,
			int thing1 = 0,
			int thing2 = default,
			string thing3 = default,
			string thing4 = null,
			CancellationToken cancellationToken = default);

		Task<string> UpdateNetworkAsync(
			string networkId,
			string networkUpdateRequest,
			CancellationToken cancellationToken = default
			);
	}
}

namespace Meraki.Api.Sections.General.Networks {
	internal class RefitPromoteCallsAttribute : Attribute
	{
	}
	public partial class NetworksSection
	{
		[RefitPromoteCalls]
		internal Meraki.Api.Interfaces.General.Networks.INetworks Networks { get; internal set; } = null!;
		public object Alerts { get; internal set; } = new();
		public string BluetoothClients { get; internal set; } = null!;
	}
}
";

		var (diagnostics, output) = GetGeneratedOutput(source);

		if (diagnostics.Length > 0)
		{
			Console.WriteLine("Diagnostics:");
			foreach (var diag in diagnostics)
			{
				Console.WriteLine("   " + diag.ToString());
			}

			Console.WriteLine();
			Console.WriteLine("Output:");
		}

		Console.WriteLine(output);
	}

	private static (ImmutableArray<Diagnostic>, string) GetGeneratedOutput(string source)
	{
		var syntaxTree = CSharpSyntaxTree.ParseText(source);

		var references = new List<MetadataReference>();
		var assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (var assembly in assemblies)
		{
			if (!assembly.IsDynamic)
			{
				references.Add(MetadataReference.CreateFromFile(assembly.Location));
			}
		}

		var compilation = CSharpCompilation.Create("foo", [syntaxTree], references, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

		ISourceGenerator generator = new RefitClassGenerator();

		var driver = CSharpGeneratorDriver.Create(generator);
		_ = driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);

		return (generateDiagnostics, outputCompilation.SyntaxTrees.Last().ToString());
	}
}
