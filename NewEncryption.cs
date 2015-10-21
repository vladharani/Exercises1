using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject5
{
    [TestClass]
    public class Encryption
    {
        [TestMethod]
        public void TestMethod1()
        {
            int nrColumns = 4;
            string mesaj = "nicaierinuecaacasa";

            decimal rows = mesaj.Length / nrColumns;
            int nrRows = (int)Math.Ceiling(rows);
            int totalLength = nrColumns * nrRows;

            if (totalLength > mesaj.Length)
            {
                do
                {
                    mesaj += "x";
                } while (mesaj.Length == totalLength);
            }
            string encriptedMessage = "";

            for (int j = 0; j < nrColumns; j++)
            {
                for (int i = j; i < mesaj.Length; i += nrRows + 1)
                {
                    encriptedMessage += mesaj.Substring(i, 1);
                }
            }
            Assert.AreEqual("neeaircsciaaana", encriptedMessage);
        }
    }
}
