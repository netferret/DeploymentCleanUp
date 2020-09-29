using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DeploymentCleanUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Dictionary<string, DateTime>();

            // @"c:\TestDeployment"
            foreach (var item in Directory.GetDirectories(args[0], "*.*", SearchOption.TopDirectoryOnly).Where(x => x.Contains("-")))
            {
                list.Add(item, Directory.GetLastWriteTime(item));
            }

            CleanupManager.ProcessDirectories(list);

            //Console.ReadKey();
        }


    }
}
