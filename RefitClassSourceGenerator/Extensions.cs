using Microsoft.CodeAnalysis;
using System.Text;

namespace RefitClassSourceGenerator;

/// <summary>
/// Roslyn symbol helpers used by the Refit class generator to render method signatures,
/// accessibility keywords and fully-qualified type names as source text.
/// </summary>
public static class Extensions
{
	/// <summary>
	/// Builds the C# source text for a method's signature, including accessibility, modifiers,
	/// return type, name, generic type parameters and parameter list.
	/// </summary>
	/// <param name="methodSymbol">The method symbol to render.</param>
	/// <param name="concreteSignature">
	/// When <see langword="true"/>, renders a concrete (implementable) signature; when
	/// <see langword="false"/>, preserves the <c>abstract</c> modifier where present.
	/// </param>
	/// <returns>The rendered method signature as a string.</returns>
	public static string GetMethodSignature(this IMethodSymbol methodSymbol, bool concreteSignature)
	{
		var result = new StringBuilder(methodSymbol.DeclaredAccessibility.ConvertAccessibilityToString());

		if (methodSymbol.IsAsync)
		{
			_ = result.Append(" async");
		}

		if (!concreteSignature && methodSymbol.IsAbstract)
		{
			_ = result.Append(" abstract");
		}

		if (methodSymbol.IsVirtual)
		{
			_ = result.Append(" virtual");
		}

		if (methodSymbol.IsStatic)
		{
			_ = result.Append(" static");
		}

		if (methodSymbol.IsOverride)
		{
			_ = result.Append(" override");
		}

		_ = methodSymbol.ReturnsVoid
			? result.Append(" void")
			: result
				.Append(' ')
				.Append((methodSymbol.ReturnType as INamedTypeSymbol)?.GetFullTypeString() ?? throw new Exception("No return type found"));

		_ = result.Append(' ')
			.Append(methodSymbol.Name)
			.Append('(');

		var isFirstParameter = true;
		foreach (var parameter in methodSymbol.Parameters)
		{
			if (isFirstParameter)
			{
				isFirstParameter = false;
			}
			else
			{
				_ = result.Append(", ");
			}

			if (parameter.RefKind == RefKind.Out)
			{
				_ = result.Append("out ");
			}
			else if (parameter.RefKind == RefKind.Ref)
			{
				_ = result.Append("ref ");
			}

			var parameterTypeString =
				(parameter.Type as INamedTypeSymbol)?.GetFullTypeString()
				?? throw new Exception($"Missing parameter type for {methodSymbol.Name} {parameter.Name} {parameter.Type}");

			_ = result
				.Append(parameterTypeString)
				.Append(' ')
				.Append(parameter.Name);

			if (parameter.HasExplicitDefaultValue)
			{
				var defaultValue = parameter.ExplicitDefaultValue?.ToString() ?? "default";

				if (parameter.ExplicitDefaultValue is bool)
				{
					defaultValue = defaultValue.ToLowerInvariant();
				}

				_ = result
					.Append(" = ")
					.Append(defaultValue ?? "default");
			}
		}

		_ = result.Append(')');

		return result.ToString();
	}

	/// <summary>
	/// Converts a Roslyn <see cref="Accessibility"/> value into its C# keyword form (for example
	/// <c>public</c> or <c>protected internal</c>), defaulting to <c>private</c> for unrecognised values.
	/// </summary>
	/// <param name="accessibility">The accessibility to convert.</param>
	/// <returns>The corresponding C# accessibility keyword.</returns>
	public static string ConvertAccessibilityToString(this Accessibility accessibility)
		=> accessibility switch
		{
			Accessibility.Internal => "internal",
			Accessibility.Private => "private",
			Accessibility.Protected => "protected",
			Accessibility.Public => "public",
			Accessibility.ProtectedAndInternal => "protected internal",
			_ => "private",
		};

	/// <summary>
	/// Renders the full type name including any generic type arguments (for example
	/// <c>Dictionary&lt;string, List&lt;int&gt;&gt;</c>), recursing into nested generic arguments.
	/// </summary>
	/// <param name="type">The named type symbol to render.</param>
	/// <returns>The type name with its generic type arguments expanded.</returns>
	public static string GetFullTypeString(this INamedTypeSymbol type)
	{
		var result = new StringBuilder(type.Name);

		if (type.TypeArguments.Length > 0)
		{
			_ = result.Append('<');

			var isFirstIteration = true;
			foreach (var typeArg in type.TypeArguments.Cast<INamedTypeSymbol>())
			{
				if (isFirstIteration)
				{
					isFirstIteration = false;
				}
				else
				{
					_ = result.Append(", ");
				}

				_ = result.Append(typeArg.GetFullTypeString());
			}

			_ = result.Append('>');
		}

		return result.ToString();
	}
}
