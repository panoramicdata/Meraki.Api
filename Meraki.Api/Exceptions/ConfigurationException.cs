using System;

namespace Meraki.Api.Exceptions;

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
