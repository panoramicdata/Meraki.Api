using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RefitClassSourceGenerator
{
	[Generator]
	public class RefitClassGenerator : ISourceGenerator
	{
		private const string RefitClassAttributeName = "RefitClass";

		public void Execute(GeneratorExecutionContext context)
		{
			try
			{

#if DEBUG
				if (!Debugger.IsAttached)
				{
					//Debugger.Launch();
				}
#endif
				var refitClasses = GetRefitClasses(context.Compilation);
				var interfaces = GetAllInterfaces(context.Compilation);
				foreach (var refitClass in refitClasses)
				{
					var refitClassNameSpace = GetNamespaceFrom(refitClass);
					var refitClassName = refitClass.Identifier.ToString();
					// Get the RefitClass Attribute
					var classAttributeType = GetRefitClassAttributeType(context.Compilation, refitClass);

					// Go and find the Interface and copy all the methods
					//var refitInterface = interfaces.Single(i => i.Identifier.ToString() == classAttributeType);

					// Get the property and it's type


					var members = new List<string>();
					//var semanticModel = context.Compilation.GetSemanticModel(refitInterface);

					//var interfaceModel = GetMatchingInterfacesInSolution(context.Compilation, classAttributeType);


					var sourceBuilder = new StringBuilder($@"
using System;
namespace {refitClassNameSpace};
public partial class {refitClassName}
{{");
					foreach (var member in members)
					{
						var returnType = "returnType";
						var methodName = "methodName";
						var parametersDeclaration = "parametersDeclaration";
						var parameters = "parameters";
						var propertyName = "WOO";
						sourceBuilder.Append($@"
	public {returnType} {methodName} {parametersDeclaration} {{
		return {propertyName}.{methodName}({parameters});
	}}
");
						//sourceBuilder.AppendLine(member.ToString());
					}
					sourceBuilder.Append(@"}
");
					var newSource = sourceBuilder.ToString();
					context.AddSource("RefitGeneratorNetworks.cs", SourceText.From(newSource, Encoding.UTF8));
				}
			}
			catch (System.Exception)
			{

				throw;
			}
		}

		private IEnumerable<InterfaceDeclarationSyntax> GetAllInterfaces(Compilation compilation)
		{
			IEnumerable<SyntaxNode> allNodes = compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
			IEnumerable<InterfaceDeclarationSyntax> allInterfaces = allNodes
				.Where(d => d.IsKind(SyntaxKind.InterfaceDeclaration))
				.OfType<InterfaceDeclarationSyntax>();
			return allInterfaces;
		}

		public IImmutableList<INamedTypeSymbol?> GetMatchingInterfacesInSolution(Compilation compilation, string name)
		{
			return compilation.SyntaxTrees.Select(syntaxTree => compilation.GetSemanticModel(syntaxTree))
				.SelectMany(
					semanticModel => semanticModel
						.SyntaxTree
						.GetRoot()
						.DescendantNodes()
						.OfType<InterfaceDeclarationSyntax>()
						.Select(interfaceDeclarationSyntax => semanticModel.GetDeclaredSymbol(interfaceDeclarationSyntax)))
				.Where(symbol => symbol != null && name == symbol.ToDisplayString())
				.ToImmutableList();
		}

		public static string GetNamespaceFrom(SyntaxNode s)
			=> s.Parent switch
			{
				NamespaceDeclarationSyntax namespaceDeclarationSyntax => namespaceDeclarationSyntax.Name.ToString(),
				FileScopedNamespaceDeclarationSyntax namespaceDeclarationSyntax => namespaceDeclarationSyntax.Name.ToString(),
				null => string.Empty, // or whatever you want to do
				_ => GetNamespaceFrom(s.Parent)
			};

		private IEnumerable<ClassDeclarationSyntax> GetRefitClasses(Compilation compilation)
		{
			IEnumerable<SyntaxNode> allNodes = compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
			IEnumerable<ClassDeclarationSyntax> allClasses = allNodes
				.Where(d => d.IsKind(SyntaxKind.ClassDeclaration))
				.OfType<ClassDeclarationSyntax>();
			return allClasses
				.Where(c => TryGetRefitClass(compilation, c) != null)
				.Cast<ClassDeclarationSyntax>();
		}

		public void Initialize(GeneratorInitializationContext context)
		{
			var x = 1;
		}

		private INamedTypeSymbol? GetRefitClassType(Compilation compilation, ClassDeclarationSyntax classDeclarationSyntax)
		{
			var attributes = classDeclarationSyntax.AttributeLists
				.SelectMany(x => x.Attributes)
				.Where(attr => attr.Name.ToString() == RefitClassAttributeName)
				.ToList();

			var refitAttribute = attributes.Single(attr => attr.Name.ToString() == RefitClassAttributeName);
			var semanticModel = compilation.GetSemanticModel(classDeclarationSyntax.SyntaxTree);

			return semanticModel.GetDeclaredSymbol(classDeclarationSyntax);

			//var typeArg = refitAttribute.ArgumentList!.Arguments[0];
			//var typeExpr = typeArg.Expression as TypeOfExpressionSyntax;
			//var typeName = typeExpr.Type.ToString();

			//return typeName;
		}

		private string GetRefitClassAttributeType(Compilation compilation, ClassDeclarationSyntax classDeclarationSyntax)
		{
			var attributes = classDeclarationSyntax.AttributeLists
				.SelectMany(x => x.Attributes)
				.Where(attr => attr.Name.ToString() == RefitClassAttributeName)
				.ToList();

			var refitAttribute = attributes.Single(attr => attr.Name.ToString() == RefitClassAttributeName);
			var semanticModel = compilation.GetSemanticModel(classDeclarationSyntax.SyntaxTree);

			var arg = refitAttribute.ArgumentList!.Arguments[0];
			//var expr = arg.Expression as TypeOfExpressionSyntax;
			//var name = expr.Type.ToString();

			return arg.ToString();
		}

		private static ClassDeclarationSyntax? TryGetRefitClass(Compilation compilation, ClassDeclarationSyntax classDeclarationSyntax)
		{
			var attributes = classDeclarationSyntax.AttributeLists
				.SelectMany(x => x.Attributes)
				.Where(attr => attr.Name.ToString() == RefitClassAttributeName)
				.ToList();

			var refitAttribute = attributes.FirstOrDefault(attr => attr.Name.ToString() == RefitClassAttributeName);

			if (refitAttribute is null)
			{
				return null;
			}

			// Must have a type argument
			if (refitAttribute.ArgumentList?.Arguments.Count != 1)
			{
				return null;
			}

			return classDeclarationSyntax;
			//return refitAttribute.ArgumentList.Arguments[0].Expression is Stringexpre
			//	? classDeclarationSyntax
			//	: null;
		}
	}
}
