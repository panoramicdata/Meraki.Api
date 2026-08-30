using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

namespace RefitClassSourceGenerator;

/// <summary>
/// Analyzer for Meraki Refit interface GET methods that enforces correct <c>AliasAs</c> usage:
/// REFIT001 requires an <c>AliasAs</c> attribute (name followed by <c>[]</c>) on <see cref="List{T}"/>
/// parameters, and REFIT002 flags an <c>AliasAs</c> attribute present on a non-<see cref="List{T}"/> parameter.
/// </summary>
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

	/// <summary>
	/// Gets the set of diagnostics this analyzer can produce (REFIT001 and REFIT002).
	/// </summary>
	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => [_requireListParameterRule, _removeAliasAsRule];

	/// <summary>
	/// Configures the analyzer and registers the syntax-node action that inspects Refit method declarations.
	/// </summary>
	/// <param name="context">The analysis context used to register actions and configure execution.</param>
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

		var hasRefitGetAttribute = HasAttributeNamed(methodDeclaration.AttributeLists, semanticModel, "GetAttribute");

		foreach (var parameter in methodDeclaration.ParameterList.Parameters)
		{
			AnalyzeParameter(context, parameter, hasRefitGetAttribute);
		}
	}

	private void AnalyzeParameter(SyntaxNodeAnalysisContext context, ParameterSyntax parameter, bool hasRefitGetAttribute)
	{
		var semanticModel = context.SemanticModel;

		if (parameter.Type is null
			|| semanticModel.GetTypeInfo(parameter.Type).Type is not INamedTypeSymbol parameterType)
		{
			return;
		}

		var aliasAsAttribute = FindAttributeNamed(parameter.AttributeLists, semanticModel, "AliasAsAttribute");

		if (hasRefitGetAttribute && parameterType.IsGenericType && parameterType.Name == "List")
		{
			// A list parameter on a GET must be aliased as "name[]", which is how Refit renders
			// the repeated query string parameter Meraki expects.
			if (!HasExpectedListAlias(semanticModel, parameter, aliasAsAttribute))
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						_requireListParameterRule,
						parameter.GetLocation(),
						parameter.Identifier.Text
						)
					);
			}

			return;
		}

		// For all request methods, if the parameter is not a generic List - it should not have an AliasAs attribute
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

	private static bool HasExpectedListAlias(
		SemanticModel semanticModel,
		ParameterSyntax parameter,
		AttributeSyntax? aliasAsAttribute)
	{
		var aliasAsConstructorArgument = aliasAsAttribute?.ArgumentList?.Arguments.FirstOrDefault();
		if (aliasAsConstructorArgument is null)
		{
			return false;
		}

		var aliasAsValue = semanticModel.GetConstantValue(aliasAsConstructorArgument.Expression);

		return aliasAsValue.HasValue
			&& aliasAsValue.Value is string alias
			&& alias == $"{parameter.Identifier.Text}[]";
	}

	private static AttributeSyntax? FindAttributeNamed(
		SyntaxList<AttributeListSyntax> attributeLists,
		SemanticModel semanticModel,
		string attributeTypeName)
		=> attributeLists
			.SelectMany(attrList => attrList.Attributes)
			.FirstOrDefault(attr => semanticModel.GetTypeInfo(attr).Type?.Name == attributeTypeName);

	private static bool HasAttributeNamed(
		SyntaxList<AttributeListSyntax> attributeLists,
		SemanticModel semanticModel,
		string attributeTypeName)
		=> FindAttributeNamed(attributeLists, semanticModel, attributeTypeName) is not null;
}
