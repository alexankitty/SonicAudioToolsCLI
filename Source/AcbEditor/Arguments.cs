using System;
using System.Collections.Generic;

namespace AcbEditor
{
    class ArgParser
    {
        public ArgParser(string[] args)
        {
            var argumentsType = typeof(Arguments);
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("--"))
                {
                    var prop = argumentsType.GetProperty(
                        args[i][2..],
                        System.Reflection.BindingFlags.Public
                            | System.Reflection.BindingFlags.Static
                            | System.Reflection.BindingFlags.IgnoreCase
                    );
                    if (prop == null)
                    {
                        Console.WriteLine($"Warning: Unrecognized argument {args[i]}");
                        continue;
                    }
                    else if (prop.PropertyType == typeof(bool))
                    {
                        if (
                            i + 1 < args.Length
                            && (
                                args[i + 1].Equals("true", StringComparison.OrdinalIgnoreCase)
                                || args[i + 1].Equals("false", StringComparison.OrdinalIgnoreCase)
                            )
                        )
                        {
                            prop.SetValue(null, Convert.ChangeType(args[i + 1], prop.PropertyType));
                            i++;
                        }
                        else
                        {
                            prop.SetValue(null, Convert.ChangeType(true, prop.PropertyType));
                        }
                    }
                    else
                    {
                        if (i + 1 < args.Length)
                        {
                            prop.SetValue(null, Convert.ChangeType(args[i + 1], prop.PropertyType));
                            i++;
                        }
                    }
                }
                else if (args[i].StartsWith("-"))
                {
                    string key = args[i].ToLowerInvariant();
                    if (!Arguments.ShortArgs.TryGetValue(key, out string longArg))
                    {
                        Console.WriteLine($"Warning: Unrecognized argument {args[i]}");
                        continue;
                    }
                    var prop = argumentsType.GetProperty(
                        longArg,
                        System.Reflection.BindingFlags.Public
                            | System.Reflection.BindingFlags.Static
                            | System.Reflection.BindingFlags.IgnoreCase
                    );
                    if (prop.PropertyType == typeof(bool))
                    {
                        prop?.SetValue(null, Convert.ChangeType(true, prop.PropertyType));
                    }
                    else
                    {
                        if (i + 1 < args.Length)
                        {
                            prop?.SetValue(
                                null,
                                Convert.ChangeType(args[i + 1], prop.PropertyType)
                            );
                            i++;
                        }
                    }
                }
                else
                {
                    Arguments.InputPath ??= args[i];
                }
            }
        }
    }

    static class Arguments
    {
        public static Dictionary<string, string> ShortArgs = new Dictionary<string, string>(
            StringComparer.OrdinalIgnoreCase
        )
        {
            { "-h", "Help" },
            { "-b", "BufferSize" },
            { "-t", "EnableThreading" },
            { "-m", "MaxThreads" },
        };
        public static string InputPath { get; set; }
        public static string OutputPath { get; set; }
        public static int BufferSize { get; set; } = 4096;
        public static bool EnableThreading { get; set; } = true;
        public static int MaxThreads { get; set; } = 4;
        public static bool Help { get; set; } = false;
    }
}
