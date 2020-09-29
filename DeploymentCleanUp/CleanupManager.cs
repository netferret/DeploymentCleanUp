using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DeploymentCleanUp
{
    public static class CleanupManager
    {
        public static void ProcessDirectories(Dictionary<string, DateTime> list)
        {
            var lastInstance = string.Empty;

            foreach (var item in list.OrderByDescending(x => x.Key))
            {
                var lastIndex = item.Key.LastIndexOf('-');

                if (lastIndex != -1)
                {
                    if (lastInstance == item.Key.Substring(0, lastIndex))
                    {
                        try
                        {
                            Console.WriteLine($"{item.Key} {item.Value} - Remove");
                            Directory.Delete(item.Key, true);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: Likely permissions {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{item.Key} {item.Value} - Keep");
                    }

                    lastInstance = item.Key.Substring(0, lastIndex);
                }

            }
        }
    }
}
