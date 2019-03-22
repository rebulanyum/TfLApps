using RoadStatus.Test.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace RoadStatus.Test
{
    public abstract class ConsoleTestBase : IDisposable
    {
        readonly StringWriter consoleOutputWriter;
        readonly TextWriter realConsoleOutputWriter;

        protected ConsoleTestBase()
        {
            consoleOutputWriter = new StringWriter();
            realConsoleOutputWriter = Console.Out;
            Console.SetOut(consoleOutputWriter);
        }

        protected string ReadConsoleOut()
        {
            return consoleOutputWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(realConsoleOutputWriter);
            consoleOutputWriter.Dispose();
        }
    }
}