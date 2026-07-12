using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using System.Collections.Immutable;
using System.Composition;

namespace RefitClassSourceGenerator;

/// <summary>
/// Code fix provider for REFIT001, which adds the required <c>AliasAs</c> attribute (with the
/// parameter name followed by <c>[]</c>) to <see cref="List{T}"/> parameters on Refit GET methods.
/// </summary>
[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(CodeFixProviderRefit001)), Shared]
public class CodeFixProviderRefit001 : CodeFixProvider
{
	/// <summary>
	/// The diagnostic identifiers this provider can fix, namely REFIT001.
	/// </summary>
	public sealed override ImmutableArray<string> FixableDiagnosticIds => ["REFIT001"];

	/// <summary>
	/// Gets the fix-all provider, allowing this fix to be applied in batch across a document, project or solution.
	/// </summary>
	/// <returns>The <see cref="WellKnownFixAllProviders.BatchFixer"/>.</returns>
	public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	/// <summary>
	/// Registers the code action that adds the missing <c>AliasAs</c> attribute for the reported REFIT001 diagnostic.
	/// </summary>
	/// <param name="context">The context supplying the document, diagnostics and cancellation token for the fix.</param>
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
		var aliasAsAttribute = generator.Attribute(aliasAsAttributeName, [generator.LiteralExpression(aliasAsValue)]);

		editor.AddAttribute(parameterSyntax, aliasAsAttribute);

		return editor.GetChangedDocument();
	}
}
