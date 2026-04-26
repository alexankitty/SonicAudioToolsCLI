using System.Reflection;

namespace AcbEditor
{
    internal static class Resources
    {
        public static string USAGE_INFO =
            $"Usage: {Assembly.GetExecutingAssembly().GetName().Name} <input path> [--BufferSize <buffer size>] [--EnableThreading <true/false>] [--MaxThreads <max threads>]";
        public const string HELP_MESSAGE =
            "ACB Editor - A tool for extracting and repacking ACB files used in CRIWARE audio middleware.\n"
            + "    -m / --MaxThreads:      Set the maximum number of threads to use for extraction/repacking (default: 4)\n"
            + "    -t / --EnableThreading: Enable or disable multithreading for extraction/repacking (default: true)\n"
            + "    -b / --BufferSize:      Set the buffer size in bytes for file operations (default: 4096)\n"
            + "    -h / --Help:            Display this help message\n"
            + "\n"
            + "Using a boolean flag without a value will set it to true (e.g., --EnableThreading will enable threading)\n"
            + "\n";
        public const string PATH_ERROR_MESSAGE = "Error: The specified input path does not exist.";
        public const string INPUT_ERROR_MESSAGE = "Error: No input path provided.";
        public const string NO_ARGS_ERROR_MESSAGE =
            "Error: No arguments provided. Use --Help for usage information.";
    }
}
