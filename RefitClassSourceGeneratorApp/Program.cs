using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using RefitClassSourceGenerator;
using System.Collections.Immutable;
using System.Reflection;

namespace TestConsoleApp;

class Program
{
	static void Main()
	{
		string source =

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
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (var assembly in assemblies)
		{
			if (!assembly.IsDynamic)
			{
				references.Add(MetadataReference.CreateFromFile(assembly.Location));
			}
		}

		var compilation = CSharpCompilation.Create("foo", new SyntaxTree[] { syntaxTree }, references, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

		// TODO: Uncomment these lines if you want to return immediately if the injected program isn't valid _before_ running generators
		//
		// ImmutableArray<Diagnostic> compilationDiagnostics = compilation.GetDiagnostics();
		//
		// if (diagnostics.Any())
		// {
		//     return (diagnostics, "");
		// }

		ISourceGenerator generator = new RefitClassGenerator();

		var driver = CSharpGeneratorDriver.Create(generator);
		driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);

		return (generateDiagnostics, outputCompilation.SyntaxTrees.Last().ToString());
	}
}
