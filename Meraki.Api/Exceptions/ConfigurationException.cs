namespace Meraki.Api.Exceptions;

/// <summary>
/// Configuration Exception
/// </summary>
public class ConfigurationException : Exception
{
	/// <summary>
	/// Initializes a new instance of the ConfigurationException class
	/// </summary>
	public ConfigurationException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the ConfigurationException class with a specified error message
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	public ConfigurationException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the ConfigurationException class with a specified error message and inner exception
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	/// <param name="innerException">The exception that is the cause of the current exception</param>
	public ConfigurationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
