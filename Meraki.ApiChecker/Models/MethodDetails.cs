using Refit;
using System.Reflection;

namespace Meraki.ApiChecker.Models;

public class MethodDetails(MethodInfo method, HttpMethodAttribute refitAttribute)
{
	public MethodInfo Method { get; set; } = method;
	public HttpMethodAttribute RefitAttribute { get; set; } = refitAttribute;

	/// <summary>
	/// A List of Types used by this method that lack at least one ApiAccess attribute
	/// </summary>
	public List<string> DeficientDataModels { get; set; } = [];

	public Type? ResponseType { get; set; }
}
