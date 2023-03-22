using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

namespace RefitAnalyzer;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class RefitInterfaceAnalyzer : DiagnosticAnalyzer
{
	private static readonly LocalizableString _title = "List parameter must have AliasAs attribute with proper format";
	private static readonly LocalizableString _messageFormat = "The parameter '{0}' of type List<T> must have an AliasAs attribute with the same name as the parameter followed by '[]'";
	private static readonly LocalizableString _description = "Meraki Refit Interface GET methods with List<T> parameters must have an AliasAs attribute with the same name as the parameter followed by '[]'.";

	private const string Category = "Refit";
	private static readonly DiagnosticDescriptor _rule = new(
		"REFIT001",
		_title,
		_messageFormat,
		Category,
		DiagnosticSeverity.Error,
		isEnabledByDefault: true,
		description: _description);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(_rule);

	public override void Initialize(AnalysisContext context)
	{
		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();
		context.RegisterSyntaxNodeAction(AnalyzeMethod, SyntaxKind.MethodDeclaration);
	}

	private void AnalyzeMethod(SyntaxNodeAnalysisContext context)
	{
		var methodDeclaration = (MethodDeclarationSyntax)context.Node;
		var semanticModel = context.SemanticModel;

		var refitGetAttribute = methodDeclaration.AttributeLists
			.SelectMany(attrList => attrList.Attributes)
			.FirstOrDefault(attr => semanticModel.GetTypeInfo(attr).Type?.Name == "GetAttribute");

		if (refitGetAttribute == null)
		{
			return;
		}

		foreach (var parameter in methodDeclaration.ParameterList.Parameters)
		{
			if (parameter.Type is null)
			{
				continue;
			}

			if (semanticModel.GetTypeInfo(parameter.Type).Type is not INamedTypeSymbol parameterType)
			{
				continue;
			}

			if (parameter.Type is not null && parameterType.IsGenericType && parameterType.Name == "List")
			{
				var aliasAsAttribute = parameter.AttributeLists
					.SelectMany(attrList => attrList.Attributes)
					.FirstOrDefault(attr => semanticModel.GetTypeInfo(attr).Type?.Name == "AliasAsAttribute");

				if (aliasAsAttribute?.ArgumentList is not null)
				{
					var aliasAsConstructorArgument = aliasAsAttribute.ArgumentList.Arguments.FirstOrDefault();
					if (aliasAsConstructorArgument is not null)
					{
						var expectedAlias = $"{parameter.Identifier.Text}[]";
						var aliasAsValue = semanticModel.GetConstantValue(aliasAsConstructorArgument.Expression);

						if (aliasAsValue.HasValue && aliasAsValue.Value is string alias && alias == expectedAlias)
						{
							continue;
						}
					}
				}

				context.ReportDiagnostic(
					Diagnostic.Create(
						_rule,
						parameter.GetLocation(),
						parameter.Identifier.Text
						)
					);
			}
		}
	}
}