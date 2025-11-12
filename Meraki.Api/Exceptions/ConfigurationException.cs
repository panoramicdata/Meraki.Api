namespace Meraki.Api.Exceptions;

/// <summary>
/// Configuration Exception
/// </summary>
public class ConfigurationException : Exception
{
	public ConfigurationException()
	{
	}

	public ConfigurationException(string message)
		: base(message)
	{
	}

	public ConfigurationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
