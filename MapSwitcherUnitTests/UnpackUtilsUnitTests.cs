﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionMapSwitcher.Classes;
using SessionMapSwitcher.Utils;

namespace MapSwitcherUnitTests
{
    [TestClass]
    public class UnpackUtilsUnitTests
    {
        [TestMethod]
        public void Test_DeleteOriginalMapFileBackup_Folder_Exists_DeletesCorrectly()
        {
            SessionPath.ToSession = "D:\\Session_Modding\\Session_Experiment";
            UnpackUtils.DeleteOriginalMapFileBackup();

            Assert.IsFalse(Directory.Exists(SessionPath.ToOriginalSessionMapFiles));
        }
    }
}