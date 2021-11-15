using Refit;
using System.Reflection;

namespace Meraki.ApiChecker.Models;

public class MethodDetails
{
	public MethodInfo Method { get; set; }
	public HttpMethodAttribute RefitAttribute { get; set; }

	public MethodDetails(MethodInfo method, HttpMethodAttribute refitAttribute)
	{
		Method = method;
		RefitAttribute = refitAttribute;
	}
}
