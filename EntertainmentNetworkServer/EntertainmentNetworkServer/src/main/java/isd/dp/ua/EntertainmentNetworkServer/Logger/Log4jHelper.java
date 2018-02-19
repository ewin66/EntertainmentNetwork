package isd.dp.ua.EntertainmentNetworkServer.Logger;

import org.apache.log4j.Logger;

/*
 * Represents adapter for log4j logger
 */
public class Log4jHelper
{
	private final static Logger logger = Logger.getLogger(Log4jHelper.class);
	
	/* 
	 * logs exception text and stack trace as error level
	 */
	public static void error(Exception ex)
	{
		logger.error(ex, ex);
	}
	
	/*
	 *  logs error level messages. Supports format specifiers for String.Format.
	 */
	public static void error(String message, Object... args)
	{
		logger.error(String.format(message, args));
	}
	
	/* 
	 * logs exception text and stack trace as log fatal level
	 */
	public static void fatal(Exception ex)
	{		
		logger.fatal(ex, ex);		
	}
	
	/* 
	 * logs debug level messages. Supports format specifiers for String.Format.
	 */
	public static void debug(String message, Object... args)
	{
		logger.debug(String.format(message, args));
	}
	
}
