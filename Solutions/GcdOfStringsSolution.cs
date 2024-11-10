using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class GcdOfStringsSolution
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;

            int n = n1 < n2 ? n1 : n2;

            if (str1 == str2)
            {
                return str1;
            }

            if (str1 == null || str2 == null || str1 + str2 != str2 + str1) 
            {
                return "";
            }

            for (int i = n; i >= 1; i--)
            {
                if (n1 < n2)
                {
                    string x = str1[..i];
                    if (str2.Contains(x) && n2 % i == 0 && n1 % i == 0)
                    { 
                        return x; 
                    }
                }
                else if (n2 < n1)
                {
                    string x = str2[..i];
                    if (str1.Contains(x) && n1 % i == 0 && n2 % i == 0)
                    {
                        return x;
                    }
                }
            }

            return "";
        }
    }
}
