using Intersect.Plugins;
using Microsoft.Extensions.Logging;

namespace Blinkuz.Plugins.Tools.Logging;

public static class Logger
{
    public static IPluginBaseContext Context { get; set; }

    public static bool WriteToConsole { get; set; }

    public static void Write(LogLevel level, string message)
    {
        if (WriteToConsole)
        {
            Console.WriteLine(message);
        }

        switch (level)
        {
            case LogLevel.Error:
                Context.Logging.Plugin.LogError(message);
                break;

            case LogLevel.Info:
                Context.Logging.Plugin.LogInformation(message);
                break;

            case LogLevel.Warning:
                Context.Logging.Plugin.LogWarning(message);
                break;
        }         
    }
}

public enum LogLevel
{
    Info,
    Warning,
    Error
}