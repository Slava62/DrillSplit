using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrillSplit.Lib;
using System.IO;



namespace DrillSplit.UnitTest
{
    [TestClass]
    public class DrillSplitTests
    {
        private Model model;

        private string progTextString;

        [TestInitialize]
        public void steup()
        {
            model = new Model();
            progTextString = "";
            model.progress += this.statusRefresh;
            model.number += this.setMinSplitNumber;

            //System.Diagnostics.Debugger.Launch();
        }
        [TestCleanup]
        public void teardown()
        {
            model.progress -= this.statusRefresh;
            model.number -= this.setMinSplitNumber;
        }

        [TestMethod]
        public void splitShortNCTest()
        {
            progTextString = getFileData("test_short.nc");
            model.setProgTextString(progTextString);
            try
            {
                Assert.IsTrue(model.splitProgram());
            }
            catch (Exception e)
            {
                Assert.IsFalse(true, e.Message);
                return;
            }
        }

        [TestMethod]
        public void splitNCTest()
        {
            progTextString = getFileData("test.nc");
            model.setProgTextString(progTextString);
            try
            {
                Assert.IsTrue(model.splitProgram());
            }
            catch (Exception e)
            {
                Assert.IsFalse(true, e.Message);
                return;
            }
        }

        private string getFileData(string file)
        {
            string temp = "";
            try
            {
                StreamReader fReader = new StreamReader(new FileStream(file, FileMode.Open));
                temp = fReader.ReadToEnd();
                fReader.Close();
            }
            catch (IOException ex)
            {
                Console.Write(DateTime.Now.ToString() + " " + ex.Message);
            }
            return temp;
        }

        private void statusRefresh(string x, string y, string z, string r, string q, string f, int i)
        {

        }

        private void setMinSplitNumber(int number)
        {

        }
    }
}
