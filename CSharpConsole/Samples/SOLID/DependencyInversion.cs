using System;
using System.Collections.Generic;

namespace CSharpConsole.Samples.SOLID
{
    public class SampleWithNonDependencyInversion
    {
        private Logger _logger = new Logger();

        public void AddNewElement(ICollection<string> collection)
        {
            var element = "NewElement";
            collection.Add(element);

            _logger.LogDebug($"Element: {element} added to the collection");
        }
    }

    public class DependencyInversion
    {
        private ILogger _logger;

        public DependencyInversion(ILogger logger)
        {
            _logger = logger;
        }

        public void AddNewElement(ICollection<string> collection)
        {
            var element = "NewElement";
            collection.Add(element);

            _logger.LogDebug($"Element: {element} added to the collection");
        }
    }

    public class Logger : ILogger
    {
        public void LogDebug(string msg)
        {
            Console.WriteLine($"DEBUG - {msg}");
        }

        public void LogWarning(string msg)
        {
            Console.WriteLine($"DEBUG - {msg}");
        }

        public void LogError(string msg)
        {
            Console.WriteLine($"DEBUG - {msg}");
        }
    }

    public class DbLogger : ILogger
    {
        public void LogDebug(string msg)
        {
            Console.WriteLine($"DEBUG - {msg}");
        }

        public void LogWarning(string msg)
        {
            Console.WriteLine($"DEBUG - {msg}");
        }

        public void LogError(string msg)
        {
            Console.WriteLine($"DEBUG - {msg}");
        }
    }

    public interface ILogger
    {
        void LogDebug(string msg);
        void LogWarning(string msg);
        void LogError(string msg);
    }
}
