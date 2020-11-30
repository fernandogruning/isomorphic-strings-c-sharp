using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsomorphicStrings;
using System;

namespace IsomorphicStringsTest {
  [TestClass]
  public class UnitTest1 {
    [TestMethod]
    public void TestIsAABXXYIso() {
      string str1 = "aab";
      string str2 = "xxy";
      bool result = IsoLibrary.CheckIso(str1, str2);

      Assert.IsTrue(result, String.Format("Expected {0} to be: true. Got {1}", str1 + "-" + str2, result));
    }

    [TestMethod]
    public void TestIsAABXXYNotIso() {
      string str1 = "aab";
      string str2 = "xxxy";
      bool result = IsoLibrary.CheckIso(str1, str2);

      Assert.IsFalse(result, String.Format("Expected {0} to be: false. Got {1}", str1 + "-" + str2, result));
    }

    [TestMethod]
    public void TestIsABAXYXIso() {
      string str1 = "aba";
      string str2 = "xyx";
      bool result = IsoLibrary.CheckIso(str1, str2);

      Assert.IsTrue(result, String.Format("Expected {0} to be: true. Got {1}", str1 + "-" + str2, result));
    }

    [TestMethod]
    public void TestIsAABYXXNotIso() {
      string str1 = "aab";
      string str2 = "yxx";
      bool result = IsoLibrary.CheckIso(str1, str2);

      Assert.IsFalse(result, String.Format("Expected {0} to be: false. Got {1}", str1 + "-" + str2, result));
    }
  }
}
