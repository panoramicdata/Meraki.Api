using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using System.Collections.Immutable;
using System.Composition;

namespace RefitClassSourceGenerator;
[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(CodeFixProviderRefit001)), Shared]
public class CodeFixProviderRefit001 : CodeFixProvider
{
	public sealed override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create("REFIT001");

	public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

		var diagnostic = context.Diagnostics.First();
		var diagnosticSpan = diagnostic.Location.SourceSpan;

		// Find the parameter syntax node
		var parameterSyntax = root?.FindToken(diagnosticSpan.Start).Parent?.AncestorsAndSelf().OfType<ParameterSyntax>().First();
		if (parameterSyntax is null)
		{
			return;
		}

		context.RegisterCodeFix(
			CodeAction.Create(
				title: "Add AliasAs attribute",
				createChangedDocument: c => AddAliasAsAttributeAsync(context.Document, parameterSyntax, c),
				equivalenceKey: nameof(CodeFixProviderRefit001)),
			diagnostic);
	}

	private static async Task<Document> AddAliasAsAttributeAsync(Document document, ParameterSyntax parameterSyntax, CancellationToken cancellationToken)
	{
		var editor = await DocumentEditor.CreateAsync(document, cancellationToken).ConfigureAwait(false);
		var generator = editor.Generator;

		var aliasAsAttributeName = generator.IdentifierName("AliasAs");
		var aliasAsValue = $"{parameterSyntax.Identifier.Text}[]";
		var aliasAsAttribute = generator.Attribute(aliasAsAttributeName, new[] { generator.LiteralExpression(aliasAsValue) });

		editor.AddAttribute(parameterSyntax, aliasAsAttribute);

		return editor.GetChangedDocument();
	}
}
