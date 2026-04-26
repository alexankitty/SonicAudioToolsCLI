using System.Reflection;

namespace CsbEditor
{
    internal static class Resources
    {
        public static string USAGE_INFO =
            $"Usage: {Assembly.GetExecutingAssembly().GetName().Name} <input path> [--BufferSize <buffer size>] [--EnableThreading <true/false>] [--MaxThreads <max threads>]";
        public const string PATH_ERROR_MESSAGE = "Error: The specified input path does not exist.";
        public const string INPUT_ERROR_MESSAGE = "Error: No input path provided.";
        public const string NO_ARGS_ERROR_MESSAGE =
            "Error: No arguments provided. Use --Help for usage information.";
        public const string HELP_MESSAGE =
            """
CSB Editor
==========

Usage:
Drag and drop a .CSB file to unpack its contents to a directory.
The directory will have the same name as the .CSB file, but without
its extension.

Also the .CPK file will be extracted too, if it exists.

In the deepest directories, you will see .ADX files, named "Intro.adx"
or "Loop.adx". The ADX files are literally what the names say. You can
add/delete/modify them freely.

The sample rate and channel count information will be automatically
updated in the CSB file if you use an ADX file with different sample
rate or channel count than original. 

To pack the .CSB file back, you gotta have the extracted directory
and the .CSB file in the same directory. Drag and drop the directory 
to the .EXE file, it will collect all the files inside directory
and pack them back.
"""
            + "\n"
            + "    -m / --MaxThreads:      Set the maximum number of threads to use for extraction/repacking (default: 4)\n"
            + "    -t / --EnableThreading: Enable or disable multithreading for extraction/repacking (default: true)\n"
            + "    -b / --BufferSize:      Set the buffer size in bytes for file operations (default: 4096)\n"
            + "    -h / --Help:            Display this help message\n"
            + "\n"
            + "Using a boolean flag without a value will set it to true (e.g., --EnableThreading will enable threading)\n"
            + "\n";
    }
}
