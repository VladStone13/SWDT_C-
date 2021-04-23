using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace TestProject1
{
    public class ListFilterer
    {
        public static List<object> GetIntegersFromList(List<object> lst)
        {
            List<object> res = new List<object>();

            foreach (var obj in lst)
            {
                if (obj.GetType() == typeof(int))
                {
                    res.Add(obj);
                }
            }

            return res;
        }

        
        public static char FirstNonRepeatingLetter(string str)
        {
            while(true)
            {
                if (string.IsNullOrEmpty(str))
                {
                    return '\0';
                }
                int count = str.Count(f => f == char.ToUpper(str[0])) + str.Count(f => f == char.ToLower(str[0]));
                if (count == 1)
                {
                    return str[0];
                }
                char[] charsToTrim = {char.ToUpper(str[0]), char.ToLower(str[0])};
                str = str.Trim(charsToTrim);
            }
        }
        
        private static bool isSecondBiggerThanFirst(string firstName1, string lastName1, string firstName2, string lastName2) {
            if(String.Compare(lastName2, lastName1, StringComparison.Ordinal) < 0) {
                return true;
            }
            else if (lastName2.CompareTo(lastName1) == 0) {
                if(firstName2.CompareTo(firstName1) < 0) {
                    return true;
                }
            }

            return false;
        }
        
        public static string OrderPeople(string str) {
            List<string> lastNames = new List<string>();
            List<string> firstNames = new List<string>();

            string firstName = "";
            string lastName = "";


            bool ifFirstName = true;

            foreach (char c in str) {

                if (c == ':') {
                    ifFirstName = !ifFirstName;
                    firstNames.Add(firstName);
                    firstName = "";
                }
                else if (c == ';') {
                    ifFirstName = !ifFirstName;
                    lastNames.Add(lastName);
                    lastName = "";
                }
                else if (ifFirstName) {
                    firstName += c;
                }
                else {
                    lastName += c;
                }
            }

            lastNames.Add(lastName);

            for (int i = 0; i < firstNames.Count; ++i) {
                for (int j = 0 ; j < firstNames.Count - 1; ++j) {
                    if(isSecondBiggerThanFirst(firstNames[j], lastNames[j],
                        firstNames[j+1], lastNames[j+1]))
                    {
                        string tmp = lastNames[j];
                        lastNames[j] = lastNames[j + 1];
                        lastNames[j + 1] = tmp;

                        tmp = firstNames[j];
                        firstNames[j] = firstNames[j + 1];
                        firstNames[j + 1] = tmp;
                    }
                }
            }

            String res = "";
            for (int i = 0; i < firstNames.Count; ++i) {
                res += '(' + lastNames[i].ToUpper() + ", " +
                       firstNames[i].ToUpper()+ ")";
            }

            return res;
        }
    }
}