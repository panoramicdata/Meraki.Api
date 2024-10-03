using Microsoft.CodeAnalysis;
using System.Text;

namespace RefitClassSourceGenerator;

public static class Extensions
{
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
