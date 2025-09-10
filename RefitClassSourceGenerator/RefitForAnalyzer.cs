
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

namespace RefitClassSourceGenerator;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class RefitForAnalyzer : DiagnosticAnalyzer
{
	public const string DiagnosticId = "REFIT003";

	private static readonly LocalizableString _title = "RefitFor parameter must be an interface";
	private static readonly LocalizableString _messageFormat = "The type '{0}' passed to RefitFor must be an interface";
	private static readonly LocalizableString _description = "RefitFor should only be used with interface types.";
	private const string Category = "Refit";

	private static readonly DiagnosticDescriptor _rule = new(
		DiagnosticId,
		_title,
		_messageFormat,
		Category,
		DiagnosticSeverity.Error,
		isEnabledByDefault: true,
		description: _description);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => [_rule];

	public override void Initialize(AnalysisContext context)
	{
		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();
		context.RegisterSyntaxNodeAction(AnalyzeInvocation, SyntaxKind.InvocationExpression);
	}

	private void AnalyzeInvocation(SyntaxNodeAnalysisContext context)
	{
		var invocationExpr = (InvocationExpressionSyntax)context.Node;

		var symbolInfo = context.SemanticModel.GetSymbolInfo(invocationExpr);
		if (symbolInfo.Symbol is not IMethodSymbol methodSymbol)
		{
			return;
		}

		if (!methodSymbol.IsGenericMethod || methodSymbol.Name != "RefitFor")
		{
			return;
		}

		// Ensure it's the one from MerakiClient
		if (methodSymbol.ContainingType?.ToDisplayString() != "Meraki.Api.MerakiClient")
		{
			return;
		}

		if (methodSymbol.TypeArguments.Length != 1)
		{
			return;
		}

		var typeArgument = methodSymbol.TypeArguments[0];

		if (typeArgument.TypeKind != TypeKind.Interface)
		{
			var diagnostic = Diagnostic.Create(
				_rule,
				invocationExpr.GetLocation(),
				typeArgument.Name);
			context.ReportDiagnostic(diagnostic);
		}
	}
}
