using System;
using System.Collections.Generic;

namespace IsomorphicStrings {
  public static class IsoLibrary {
    public static bool CheckIso(string str1, string str2) {
      if (str1.Length != str2.Length) {
        return false;
      }

      Dictionary<char, char> dict = new Dictionary<char, char>();

      for (int i = 0; i < str1.Length; i++) {
        if (dict.ContainsKey(str1[i])) {
          if (dict[str1[i]] != str2[i]) {
            return false;
          }
        } else {
          if (dict.ContainsValue(str2[i])) {
          }

          dict.Add(str1[i], str2[i]);
        }
      }

      return true;
    }
  }
}
