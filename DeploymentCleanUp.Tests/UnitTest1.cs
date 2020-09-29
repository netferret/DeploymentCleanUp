using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DeploymentCleanUp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list = new Dictionary<string, DateTime>();


            list.Add("BonusEngine-feature-sgb-4106-bfit-83212---no-batsmen-for-fix-5", new DateTime(2020, 09, 24, 9, 43, 0));
            list.Add("BonusEngine-feature-sgb-4106-bfit-83212---no-batsmen-for-fix-4", new DateTime(2020, 09, 24, 9, 4, 0));
            list.Add("BonusEngine-feature-sgb-4106-bfit-83212---no-batsmen-for-fix-6", new DateTime(2020, 09, 25, 9, 32, 0));
            list.Add("EventsApi-feature-sgb-4106-bfit-83212---no-batsmen-for-fix-4", new DateTime(2020, 09, 24, 9, 7, 0));

            list.Add("BonusEngine-feature-sgb-4106-bfit-83212---no-batsmen-for-fix-9", new DateTime(2020, 09, 29, 9, 41, 0));
            list.Add("BonusEngine-feature-sgb-4106-bfit-83212---no-batsmen-for-fix-8", new DateTime(2020, 09, 28, 13, 14, 0));

            CleanupManager.ProcessDirectories(list);
        }
    }
}
