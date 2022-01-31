using Microsoft.CodeAnalysis;
using System;
using System.Linq;

namespace RefitClassSourceGenerator;

public static class Extensions
{
	public static string GetMethodSignature(this IMethodSymbol methodSymbol, bool concreteSignature)
	{
		string result = methodSymbol.DeclaredAccessibility.ConvertAccessibilityToString();

		if (methodSymbol.IsAsync)
		{
			result += " async";
		}

		if (!concreteSignature && methodSymbol.IsAbstract)
		{
			result += " abstract";
		}

		if (methodSymbol.IsVirtual)
		{
			result += " virtual";
		}

		if (methodSymbol.IsStatic)
		{
			result += " static";
		}

		if (methodSymbol.IsOverride)
		{
			result += " override";
		}

		if (methodSymbol.ReturnsVoid)
		{
			result += " void";
		}
		else
		{
			result += " " + (methodSymbol.ReturnType as INamedTypeSymbol)?.GetFullTypeString() ?? throw new Exception("No return type found");
		}

		result += " " + methodSymbol.Name + "(";

		bool isFirstParameter = true;
		foreach (IParameterSymbol parameter in methodSymbol.Parameters)
		{
			if (isFirstParameter)
			{
				isFirstParameter = false;
			}
			else
			{
				result += ", ";
			}

			if (parameter.RefKind == RefKind.Out)
			{
				result += "out ";
			}
			else if (parameter.RefKind == RefKind.Ref)
			{
				result += "ref ";
			}

			string parameterTypeString =
				(parameter.Type as INamedTypeSymbol)?.GetFullTypeString()
				?? throw new Exception($"Missing parameter type for {methodSymbol.Name} {parameter.Name} {parameter.Type}");

			result += parameterTypeString;

			result += " " + parameter.Name;

			if (parameter.HasExplicitDefaultValue)
			{
				result += " = " + (parameter.ExplicitDefaultValue?.ToString() ?? "default");
			}
		}

		result += ")";

		return result;
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
		string result = type.Name;

		if (type.TypeArguments.Count() > 0)
		{
			result += "<";

			bool isFirstIteration = true;
			foreach (INamedTypeSymbol typeArg in type.TypeArguments)
			{
				if (isFirstIteration)
				{
					isFirstIteration = false;
				}
				else
				{
					result += ", ";
				}

				result += typeArg.GetFullTypeString();
			}

			result += ">";
		}

		return result;
	}
}
