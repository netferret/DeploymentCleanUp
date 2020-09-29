using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace DeploymentCleanUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Dictionary<string, DateTime>();

            // @"c:\TestDeployment"
            foreach (var item in Directory.GetDirectories(args[0], "*-*", SearchOption.AllDirectories))
            {
                list.Add(item, Directory.GetLastWriteTime(item));
            }

            var lastInstance = string.Empty;

            foreach (var item in list.OrderByDescending(x => x.Value))
            {
                var lastIndex = item.Key.LastIndexOf('-');

                if (lastInstance == item.Key.Substring(0, lastIndex))
                {
                    Console.WriteLine($"Remove {item.Key} {item.Value}");
                    Directory.Delete(item.Key, true);
                }
                else
                {
                    Console.WriteLine($"Keep {item.Key} {item.Value}");
                }

                lastInstance = item.Key.Substring(0, lastIndex);

            }

            Console.ReadKey();
        }
    }
}
