using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using System.Collections.Immutable;
using System.Composition;

namespace RefitClassSourceGenerator;

/// <summary>
/// Code fix provider for REFIT002, which removes an <c>AliasAs</c> attribute from a parameter that
/// is not of type <see cref="List{T}"/> and therefore should not carry one.
/// </summary>
[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(CodeFixProviderRefit002)), Shared]
public class CodeFixProviderRefit002 : CodeFixProvider
{
	/// <summary>
	/// The diagnostic identifiers this provider can fix, namely REFIT002.
	/// </summary>
	public sealed override ImmutableArray<string> FixableDiagnosticIds => ["REFIT002"];

	/// <summary>
	/// Gets the fix-all provider, allowing this fix to be applied in batch across a document, project or solution.
	/// </summary>
	/// <returns>The <see cref="WellKnownFixAllProviders.BatchFixer"/>.</returns>
	public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	/// <summary>
	/// Registers the code action that removes the offending <c>AliasAs</c> attribute for the reported REFIT002 diagnostic.
	/// </summary>
	/// <param name="context">The context supplying the document, diagnostics and cancellation token for the fix.</param>
	public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

		var diagnostic = context.Diagnostics.First();
		var diagnosticSpan = diagnostic.Location.SourceSpan;

		// Find the attribute syntax node
		var parameterSyntax = root?.FindToken(diagnosticSpan.Start).Parent?.AncestorsAndSelf().OfType<ParameterSyntax>().FirstOrDefault();
		if (parameterSyntax is null)
		{
			return;
		}

		context.RegisterCodeFix(
			CodeAction.Create(
				title: "Remove AliasAs attribute",
				createChangedDocument: c => RemoveAliasAsAttributeAsync(context.Document, parameterSyntax, c),
				equivalenceKey: nameof(CodeFixProviderRefit002)),
			diagnostic);
	}

	private static async Task<Document> RemoveAliasAsAttributeAsync(Document document, ParameterSyntax parameterSyntax, CancellationToken cancellationToken)
	{
		//var root = await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(false);

		//var newRoot = root!.RemoveNode(parameterSyntax, SyntaxRemoveOptions.KeepExteriorTrivia)!;

		//return document.WithSyntaxRoot(newRoot);
		var editor = await DocumentEditor.CreateAsync(document, cancellationToken).ConfigureAwait(false);

		var aliasAsAttribute = parameterSyntax.AttributeLists
			.SelectMany(attrList => attrList.Attributes)
			.FirstOrDefault(attr => attr.Name.ToString() == "AliasAs");

		if (aliasAsAttribute != null)
		{
			if (aliasAsAttribute.Parent is not AttributeListSyntax attributeList)
			{
				return document;
			}

			var updatedAttributeList = attributeList.RemoveNode(aliasAsAttribute, SyntaxRemoveOptions.KeepNoTrivia)!;

			if (updatedAttributeList.Attributes.Count == 0)
			{
				editor.RemoveNode(attributeList, SyntaxRemoveOptions.KeepLeadingTrivia);
			}
			else
			{
				editor.ReplaceNode(attributeList, updatedAttributeList);
			}
		}

		return editor.GetChangedDocument();
	}
}
