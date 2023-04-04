using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

namespace RefitAnalyzer;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class RefitInterfaceAnalyzer : DiagnosticAnalyzer
{
	private static readonly LocalizableString _requireListParameterRule_Title = "List parameter must have AliasAs attribute with proper format";
	private static readonly LocalizableString _requireListParameterRule_MessageFormat = "The parameter '{0}' of type List<T> must have an AliasAs attribute with the same name as the parameter followed by '[]'";
	private static readonly LocalizableString _requireListParameterRule_Description = "Meraki Refit Interface GET methods with List<T> parameters must have an AliasAs attribute with the same name as the parameter followed by '[]'.";

	private static readonly LocalizableString _removeAliasAsRule_Title = "AliasAs attribute should only be present for parameters of type List<T>";
	private static readonly LocalizableString _removeAliasAsRule_MessageFormat = "The parameter '{0}' should not have an AliasAs attribute";
	private static readonly LocalizableString _removeAliasAsRule_Description = "Meraki Refit Interface GET methods parameters should not have an AliasAs attribute unless they are of type List<T>.";


	private const string Category = "Refit";
	private static readonly DiagnosticDescriptor _requireListParameterRule = new(
		"REFIT001",
		_requireListParameterRule_Title,
		_requireListParameterRule_MessageFormat,
		Category,
		DiagnosticSeverity.Error,
		isEnabledByDefault: true,
		description: _requireListParameterRule_Description);
	private static readonly DiagnosticDescriptor _removeAliasAsRule = new(
		"REFIT002",
		_removeAliasAsRule_Title,
		_removeAliasAsRule_MessageFormat,
		Category,
		DiagnosticSeverity.Error,
		isEnabledByDefault: true,
		description: _removeAliasAsRule_Description);


	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(
		_requireListParameterRule,
		_removeAliasAsRule);

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
						_requireListParameterRule,
						parameter.GetLocation(),
						parameter.Identifier.Text
						)
					);
			}
			else
			{
				// The parameter is not a generic List - it should not have an AliasAs attribute
				var aliasAsAttribute = parameter.AttributeLists
					.SelectMany(attrList => attrList.Attributes)
					.FirstOrDefault(attr => semanticModel.GetTypeInfo(attr).Type?.Name == "AliasAsAttribute");

				if (aliasAsAttribute is not null)
				{
					context.ReportDiagnostic(
						Diagnostic.Create(
							_removeAliasAsRule,
							parameter.GetLocation(),
							parameter.Identifier.Text
							)
						);
				}
			}
		}
	}
}